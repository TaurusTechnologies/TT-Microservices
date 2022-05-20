import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as ProjectStore from '../store/Project';

interface InputProps extends React.InputHTMLAttributes<HTMLInputElement> {
    name: string;
    label: string;
    value: string;
    endpoint: string;
}

const AutoSubmitTextInput: React.FC<InputProps> = ({ name, label, value, endpoint, ... rest }) => {
    const [val, setValue] = React.useState(value);

    let postData = async (url = '', data = {}) => {
        // Default options are marked with *
        const response = await fetch(url, {
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, *cors, same-origin
            cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
            credentials: 'same-origin', // include, *same-origin, omit
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            redirect: 'follow', // manual, *follow, error
            referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
            body: JSON.stringify(data) // body data type must match "Content-Type" header
        });
        return response.json(); // parses JSON response into native JavaScript objects
    }

    let onChange = async (e: React.ChangeEvent<HTMLInputElement>) => {
        setValue(e.target.value)
        await postData('endpoint', { field: name, value: e.target.value});
    }

    return (
        <div className="">
            <label htmlFor={name}>{label}</label>
            <input onChange={onChange} id={name} defaultValue={value} {...rest}></input>
        </div>
    );
}


// At runtime, Redux will merge together...
type ProjectProps =
    ProjectStore.ProjectState // ... state we've requested from the Redux store
    & typeof ProjectStore.actionCreators // ... plus action creators we've requested
    & RouteComponentProps<{ id: string }>; // ... plus incoming routing parameters

class FetchData extends React.PureComponent<ProjectProps> {
    private timerID: NodeJS.Timeout | undefined; 

    // This method is called when the component is first added to the document
    public componentDidMount() {
        this.ensureDataFetched();
        this.timerID = setInterval(() => this.setState({ time: Date.now() }), 30000);
    }

    // This method is called when the route parameters change
    public componentDidUpdate() {
        this.ensureDataFetched();

    }

    public componentWillUnmount() {
        clearInterval(this.timerID as NodeJS.Timeout);
    }

    public render() {
        return (
            <React.Fragment>
                {/*<h1 id="tabelLabel">Project</h1>*/}
                {this.renderProject()}
            </React.Fragment>
        );
    }

    private ensureDataFetched() {
        const id = parseInt(this.props.match.params.id, 10) || 0;
        this.props.requestProject(id);
    }

    async postData(url = '', data = {}) {
        // Default options are marked with *
        const response = await fetch(url, {
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, *cors, same-origin
            cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
            credentials: 'same-origin', // include, *same-origin, omit
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            redirect: 'follow', // manual, *follow, error
            referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
            body: JSON.stringify(data) // body data type must match "Content-Type" header
        });
        return response.json(); // parses JSON response into native JavaScript objects
    }

    private renderProject() {
        //console.info(this.props);
        if (this.props.isLoading) {
            return(<div></div>);
        }

        let updateProjectData = async (data: any) => {
            return await this.postData('project/rooms', {id: this.props.match.params.id}); // parses JSON response into native JavaScript objects
        }

        return (
            <div>
                <h2>{this.props.project.name}</h2>

                {this.props.rooms.map((room: ProjectStore.ProjectRoom) =>
                    <div>
                        <h3>{room.roomName}</h3>
                        <table key={room.projectRoomId} className='table table-striped' aria-labelledby="tabelLabel">
                            <thead>
                                <tr>
                                    <th>Bin</th>
                                    <th>Qty</th>
                                    <th>Part Number</th>
                                    <th>Description</th>
                                    <th>PO #</th>
                                    <th>Tracking #</th>
                                    <th>ETA</th>
                                    <th>Vendor</th>
                                    <th>Discount Price</th>
                                    <th>Cost</th>
                                    <th>Total</th>
                                    <th>Notes</th>
                                    <th>Ordered By</th>
                                    <th>&nbsp;</th>
                                </tr>
                            </thead>
                            <tbody>
                                {room.products.map((product: ProjectStore.ProjectRoomProduct) =>
                                    <tr key={product.projectProductId}>
                                        <td>{product.binNumber}</td>
                                        <td>{product.quantity}</td>
                                        <td>{product.partNumber}</td>
                                        <td>
                                            <AutoSubmitTextInput
                                                name="description"
                                                label=""
                                                value={product.description}
                                                endpoint="roomdata/10"
                                            />
                                        </td>
                                        <td>{product.poNumber}</td>
                                        <td>{product.eta}</td>
                                        <td>{product.vendor}</td>
                                        <td>${product.quotePrice}</td>
                                        <td>${product.price}</td>
                                        <td>${(product.price || 0) * product.quantity}</td>
                                        <td>
                                            <AutoSubmitTextInput
                                                name="orderNotes"
                                                label=""
                                                value={product.orderNotes}
                                                endpoint="roomdata/10"
                                            />
                                        </td>
                                    </tr>
                                )}
                            </tbody>
                        </table>
                    </div>
                )}
            </div>
        );
    }
}

export default connect(
    (state: ApplicationState) => state.project, // Selects which state properties are merged into the component's props
    ProjectStore.actionCreators // Selects which action creators are merged into the component's props
)(FetchData as any);