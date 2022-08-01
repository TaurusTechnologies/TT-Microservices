import { Action, Reducer } from 'redux';
import { AppThunkAction } from '.';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ProjectState {
    isLoading: boolean;
    id: number;
    project: Project;
    rooms: ProjectRoom[];
    itemHistory: ItemHistory[];
}

export interface ProjectStartStopDates {
    ProjectStartStopDateId: number;
    ProjectId: number;
    StartDate?: Date;
    EndDate?: Date;
    Description: string;
}

export interface ProjectCustomer {
    customerId: number;
    name: string;
}

export interface ProjectLocation {
    locationName: string;
    address1: string;
    address2: string;
    city: string;
    state: string;
    zip: string;
}

export interface Project {
    projectId: number;
    name: string;
    start?: Date;
    completion?: Date;
    dateDescription?: string;
    startStopDates?: ProjectStartStopDates[];
    jobNumber: string;
    poNumber: string;
    customer?: ProjectCustomer;
    phoneNumber: string;
    faxNumber: string;
    cellNumber: string;
    contactName: string;
    contactEmail: string;
    installAddress?: ProjectLocation;
    shippingAddress?: ProjectLocation;
    billingName: string;
    billingEmail: string;
    billingAddress?: ProjectLocation;
    notes: string;
    isLegacyServicePlan: boolean;

}

export interface ProjectRoomProduct {
    received: boolean;
    projectProductId: number; 
    description: string;
    status: number;
    quantity: number;
    binNumber: string;
    vendor: string;
    trackingNumber: string;
    quotePrice?: number;
    price?: number;
    manufacturer: string;
    partNumber: string;
    poNumber: string;
    orderNotes: string;
    eta?: Date;
}

export interface ProjectRoom {
    projectRoomId: number;
    roomName: string;
    products: ProjectRoomProduct[];
}

export interface ItemHistory {
    id: number;
    type: number;
    message: string;
    author: string;
    authorId: number;
    timeStamp: string;
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

interface RequestProjectRoomsAction {
    type: 'REQUEST_PROJECT_ROOMS';
    id: number;
}

interface ReceiveProjectRoomsAction {
    type: 'RECEIVE_PROJECT_ROOMS';
    id: number;
    rooms: ProjectRoom[];
}


interface RequestItemHistoryAction {
    type: 'REQUEST_ITEM_HISTORY';
    id: number;
}

interface ReceiveItemHistoryAction {
    type: 'RECEIVE_ITEM_HISTORY';
    id: number;
    itemHistory: ItemHistory[];
}


// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestProjectAction | ReceiveProjectAction | ReceiveProjectRoomsAction | RequestProjectRoomsAction
    | ReceiveItemHistoryAction | RequestItemHistoryAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestProject: (id: number): AppThunkAction<KnownAction> => (dispatch, getState) => {
        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.project && id !== appState.project.id) {
            fetch(`project/get?id=` + id)
                .then(response => response.json() as Promise<Project>)
                .then(data => {
                    dispatch({ type: 'RECEIVE_PROJECT', id: id, project: data });
                    fetch(`project/rooms/` + id)
                        .then(response => response.json() as Promise<ProjectRoom[]>)
                        .then(data => {
                            dispatch({ type: 'RECEIVE_PROJECT_ROOMS', id: id, rooms: data });
                            fetch(`project/itemhistory` + id)
                                .then(response => response.json() as Promise<ItemHistory[]>)
                                .then(data => {
                                    dispatch({ type: 'RECEIVE_ITEM_HISTORY', id: id, itemHistory: data });
                                    fetch(`project/itemhistory` + id)
                                });

                        });
                });

            dispatch({ type: 'REQUEST_PROJECT', id: id });
        }
    }
};

// ----------------
// REDUCER - For a given state and action, returns the new state. To support time travel, this must not mutate the old state.

const unloadedState: ProjectState = {
    id: 0, isLoading: false,
    project: {
        projectId: 0, name: '', jobNumber: '', poNumber: '', phoneNumber: '',
        faxNumber: '', cellNumber: '', contactName: '',
        contactEmail: '', billingEmail: '', billingName: '',
        notes: '', isLegacyServicePlan: false
    },
    itemHistory: [],
    rooms: []
};

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
                isLoading: true,
                rooms: state.rooms,
                itemHistory: state.itemHistory
            };
        case 'RECEIVE_PROJECT':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: action.project,
                    isLoading: false,
                    rooms: state.rooms,
                    itemHistory: state.itemHistory
                };
            }
            break;
        case 'REQUEST_PROJECT_ROOMS':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                itemHistory: state.itemHistory
            };
        case 'RECEIVE_PROJECT_ROOMS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: state.project,
                    isLoading: false,
                    rooms: action.rooms,
                    itemHistory: state.itemHistory
                };
            }
            break;
        case 'REQUEST_ITEM_HISTORY':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                itemHistory: state.itemHistory
            };
        case 'RECEIVE_ITEM_HISTORY':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: state.project,
                    isLoading: false,
                    rooms: state.rooms,
                    itemHistory: action.itemHistory
                };
            }
            break;
    }

    return state;
};
