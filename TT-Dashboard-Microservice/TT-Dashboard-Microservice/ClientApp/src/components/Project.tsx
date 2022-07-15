import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as ProjectStore from '../store/Project';
import * as NumericInput from "react-numeric-input";


interface TextInputProps extends React.InputHTMLAttributes<HTMLInputElement> {
    name: string;
    label: string;
    value: string;
    endpoint: string;
}

interface NumericInputProps extends React.InputHTMLAttributes<HTMLInputElement> {
    name: string;
    label: string;
    value: number;
    endpoint: string;
}

interface CheckInputProps extends React.InputHTMLAttributes<HTMLInputElement> {
    name: string;
    label: string;
    checked: boolean;
    endpoint: string;
}

// Shared for all input.
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

const AutoSubmitCheckedInput: React.FC<CheckInputProps> = ({ name, label, checked, endpoint, ...rest }) => {
    const [val, setChecked] = React.useState(checked as boolean);

    let onChange = async (e: React.ChangeEvent<HTMLInputElement>) => {
        setChecked(!val);
        await postData(endpoint, { field: name, value: val.toString()});
    }

    return (
        <div className="">
            <label htmlFor={name}>{label}</label>
            <input
                onChange={onChange} type="checkbox"
                id={name} checked={checked}
                {...rest}></input>
        </div>
    );
}

const AutoSubmitTextInput: React.FC<TextInputProps> = ({ name, label, value, endpoint, ...rest }) => {
    const [val, setValue] = React.useState(value);

    let onChange = async (e: React.ChangeEvent<HTMLInputElement>) => {
        setValue(e.target.value);
        await postData(endpoint, { field: name, value: e.target.value });
    }

    return (
        <div className="">
            <label htmlFor={name}>{label}</label>
            <input onChange={onChange} id={name} defaultValue={value} {...rest}></input>
        </div>
    );
}

const AutoSubmitNumericInput: React.FC<NumericInputProps> = ({ name, label, value, endpoint, ...rest }) => {
    const [val, setValue] = React.useState(value);

    let onChange = async (e: React.ChangeEvent<HTMLInputElement>) => {
        setValue(parseInt(e.target.value));
        await postData(endpoint, { field: name, value: e.target.value });
    }

    return (
        <div className="">
            <label htmlFor={name}>{label}</label>
        {/*    <NumericInput*/}
        {/*        onChange={onChange}*/}
        {/*        id={name}*/}
        {/*        value={value}*/}
        {/*        min={0}*/}
        {/*        {...rest} />*/}
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
        console.info(response);
        return response.json(); // parses JSON response into native JavaScript objects
    }

    private renderProject() {
        let id = this.props.match.params.id;

        if (this.props.isLoading) {
            return(<div></div>);
        }

        //let updateProjectData = async (data: any) => {
        //    return await this.postData('project/rooms', {id: this.props.match.params.id}); // parses JSON response into native JavaScript objects
        //}

        return (
            <div>
                <h2>{this.props.project.name}</h2>
                <div>
                    <h3>Project Details</h3>
                    <ul className="">
                        <li className="bigger">
                            <b>Customer:</b>
                        {/*    <a href="/Customer/View/{this.props.project.customer?.customerId}">{this.props.project.customer?.name}</a>*/}
                        </li>
                        <li className="bigger"><b>Job Number:</b> { this.props.project.jobNumber }</li>
                        <li className="bigger"><b>PO Number:</b> {this.props.project.poNumber}</li>
                    </ul>
                {/*    <ul class="rightlist">*/}
                {/*        <li class="bigger"><b>Contact Name:</b> {{ vm.project.ContactName }}</li>*/}
                {/*        <li> <b>Contact Email:</b> {{ vm.project.Customer ? vm.project.Email : '' }}</li>*/}
                {/*        <li><b>Phone Number:</b> {{ vm.project.PhoneNumber }}</li>*/}
                {/*        <li><b>Cell Phone Number:</b> {{ vm.project.CellPhone }}</li>*/}

                {/*    </ul>*/}

                </div>

                {this.props.rooms.map((room: ProjectStore.ProjectRoom) =>
                    <div>
                        <h3>{room.roomName}</h3>
                        <table key={room.projectRoomId} className='table table-striped' aria-labelledby="tabelLabel">
                            <thead>
                                <tr>
                                    <th>Rcvd?</th>
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
                                        <td><AutoSubmitCheckedInput
                                            name="received"
                                            label=""
                                            checked={product.received}
                                            endpoint={"project/projectproduct/" + product.projectProductId + "/field"}/>
                                        </td>
                                        <td>{product.binNumber}</td>
                                        <td>
                                            <AutoSubmitNumericInput
                                                name="quantity"
                                                label=""
                                                value={product.quantity}
                                                endpoint={"project/projectproduct/" + product.projectProductId + "/field"}/>
                                        </td>
                                        <td>{product.partNumber}</td>
                                        <td>
                                            <AutoSubmitTextInput
                                                name="description"
                                                label=""
                                                value={product.description}
                                                endpoint={"project/projectproduct/" + product.projectProductId + "/field"}/>
                                        </td>
                                        <td>{product.poNumber}</td>
                                        <td>{product.trackingNumber}</td>
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
                                                endpoint={"project/projectproduct/" + product.projectProductId + "/field"}/>
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