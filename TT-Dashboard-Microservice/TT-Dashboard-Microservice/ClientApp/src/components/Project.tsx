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
                <h1 id="tabelLabel">Project</h1>
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
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{this.props.project.projectId}</td>
                        <td>{this.props.project.name}</td>
                    </tr>
                </tbody>
            </table>
        );
    }
}

export default connect(
    (state: ApplicationState) => state.project, // Selects which state properties are merged into the component's props
    ProjectStore.actionCreators // Selects which action creators are merged into the component's props
)(FetchData as any);