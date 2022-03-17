import { Action, Reducer } from 'redux';
import { AppThunkAction } from '.';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ProjectState {
    isLoading: boolean;
    id: number;
    project?: Project;
}

export interface Project {
    id: number;
    name: string;
}

// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestProjectAction {
    type: 'REQUEST_PROJECT';
    id: number;
}

interface ReceiveProjectAction {
    type: 'RECEIVE_PROJECT';
    id: number;
    project: Project;
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestProjectAction | ReceiveProjectAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestProject: (id: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.project && id !== appState.project.id) {
            fetch(`Project/Get?id=` + id)
                .then(response => response.json() as Promise<Project>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_PROJECT', id: id, project: data });
                });

            dispatch({ type: 'REQUEST_PROJECT', id: id });
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: ProjectState = { id: 0, isLoading: false };

export const reducer: Reducer<ProjectState> = (state: ProjectState | undefined, incomingAction: Action): ProjectState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_PROJECT':
            return {
                id: action.id,
                project: state.project,
                isLoading: true
            };
        case 'RECEIVE_PROJECT':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: action.project,
                    isLoading: false
                };
            }
            break;
    }

    return state;
};
