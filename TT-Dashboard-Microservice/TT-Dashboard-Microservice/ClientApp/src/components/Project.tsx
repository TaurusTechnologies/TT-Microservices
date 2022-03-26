import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as ProjectStore from '../store/Project';

// At runtime, Redux will merge together...
type ProjectProps =
    ProjectStore.ProjectState // ... state we've requested from the Redux store
    & typeof ProjectStore.actionCreators // ... plus action creators we've requested
    & RouteComponentProps<{ id: string}>; // ... plus incoming routing parameters

class FetchData extends React.PureComponent<ProjectProps> {
    // This method is called when the component is first added to the document
    public componentDidMount() {
        this.ensureDataFetched();
    }

    // This method is called when the route parameters change
    public componentDidUpdate() {
        this.ensureDataFetched();
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

    private renderProject() {
        console.info(this.props);
        if (this.props.isLoading) {
            return(<div></div>);
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
                                        <td>{product.description}</td>
                                        <td>{product.partNumber}</td>
                                        <td>{product.poNumber}</td>
                                        <td>{product.eta}</td>
                                        <td>{product.vendor}</td>
                                        <td>${product.quotePrice}</td>
                                        <td>${product.price}</td>
                                        <td>${(product.price || 0) * product.quantity}</td>
                                        <td>{product.orderNotes}</td>
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