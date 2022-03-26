import { Action, Reducer } from 'redux';
import { AppThunkAction } from '.';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface AuthState {
    isLoading: boolean;
    user: string;
    token: string;
}

export interface Auth {
    user: string;
    token: string;
}

// -----------------
// ACTIONS - These are serializable (hence replayable) descriptions of state transitions.
// They do not themselves have any side-effects; they just describe something that is going to happen.

interface RequestAuthAction {
    type: 'REQUEST_AUTH';
    user: string;
    pass: string;
}

interface ReceiveAuthAction {
    type: 'RECEIVE_AUTH';
    auth: Auth;
}

// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestAuthAction | ReceiveAuthAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestProject: (user: string, pass: string): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState) {
            fetch(`project/get?id=` + user)
                .then(response => response.json() as Promise<Auth>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_AUTH', auth: data });
                });

            dispatch({ type: 'REQUEST_AUTH', user: user, pass: pass});
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: AuthState = { isLoading: false, token: "", user: ""};

export const reducer: Reducer<AuthState> = (state: AuthState | undefined, incomingAction: Action): AuthState => {
    if (state === undefined) {
        return unloadedState;
    }

    const action = incomingAction as KnownAction;
    switch (action.type) {
        case 'REQUEST_AUTH':
            return {
                token: state.token,
                user: state.user,
                isLoading: true
            };
    //    case 'RECEIVE_AUTH':
    //        // Only accept the incoming data if it matches the most recent request. This ensures we correctly
    //        // handle out-of-order responses.
    //        }
    //        break;
    }

    return state;
};
