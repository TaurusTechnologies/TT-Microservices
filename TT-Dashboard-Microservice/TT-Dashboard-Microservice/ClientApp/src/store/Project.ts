import { Action, Reducer } from 'redux';
import { AppThunkAction } from '.';
import { InvoiceDto, ItemHistoryDto, ItemTroubleTicketDto, ProjectDto, ProjectRoomDto, ServicePlanDto } from '../apiClient/data-contracts';
import { Project as ProjectApi } from '../apiClient/Project';

// -----------------
// STATE - This defines the type of data maintained in the Redux store.

export interface ProjectState {
    isLoading: boolean;
    id: number;
    project: ProjectDto;
    rooms: ProjectRoomDto[];
    invoices: InvoiceDto[];
    itemHistory: ItemHistoryDto[];
    troubleTickets: ItemTroubleTicketDto[];
    servicePlans: ServicePlanDto[];
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
    project: ProjectDto;
}

interface RequestProjectRoomsAction {
    type: 'REQUEST_PROJECT_ROOMS';
    id: number;
}

interface ReceiveProjectRoomsAction {
    type: 'RECEIVE_PROJECT_ROOMS';
    id: number;
    rooms: ProjectRoomDto[];
}

interface RequestItemHistoryAction {
    type: 'REQUEST_ITEM_HISTORY';
    id: number;
}

interface ReceiveItemHistoryAction {
    type: 'RECEIVE_ITEM_HISTORY';
    id: number;
    itemHistory: ItemHistoryDto[];
}

interface ReceiveInvoicesAction {
    type: 'RECEIVE_INVOICES';
    id: number;
    invoices: InvoiceDto[];
}

interface RequestInvoicesAction {
    type: 'REQUEST_INVOICES';
    id: number;
}

interface ReceiveTroubleTicketsAction {
    type: 'RECEIVE_TROUBLE_TICKETS';
    id: number;
    tickets: ItemTroubleTicketDto[];
}

interface RequestTroubleTicketsAction {
    type: 'REQUEST_TROUBLE_TICKETS';
    id: number;
}

interface ReceiveServicePlansAction {
    type: 'RECEIVE_SERVICE_PLANS';
    id: number;
    servicePlans: ServicePlanDto[];
}

interface RequestServicePlansAction {
    type: 'REQUEST_SERVICE_PLANS';
    id: number;
}


// Declare a 'discriminated union' type. This guarantees that all references to 'type' properties contain one of the
// declared type strings (and not any other arbitrary string).
type KnownAction = RequestProjectAction | ReceiveProjectAction | ReceiveProjectRoomsAction | RequestProjectRoomsAction
    | ReceiveItemHistoryAction | RequestItemHistoryAction | ReceiveInvoicesAction | RequestInvoicesAction
    | ReceiveTroubleTicketsAction | RequestTroubleTicketsAction | ReceiveServicePlansAction | RequestServicePlansAction;

// ----------------
// ACTION CREATORS - These are functions exposed to UI components that will trigger a state transition.
// They don't directly mutate state, but they can have external side-effects (such as loading data).

export const actionCreators = {
    requestProject: (id: number): AppThunkAction<KnownAction> => (dispatch, getState) => {

        // Only load data if it's something we don't already have (and are not already loading)
        const appState = getState();
        if (appState && appState.project && id !== appState.project.id) {

            const api = new ProjectApi();
            api.getProject({ id: id })
                .then(response => {
                    dispatch({ type: 'RECEIVE_PROJECT', id: id, project: response.data });
                    api.roomsDetail(id).then(response => {
                        dispatch({ type: 'RECEIVE_PROJECT_ROOMS', id: id, rooms: response.data });
                        api.itemhistoryDetail(id).then(response => {
                            dispatch({ type: 'RECEIVE_ITEM_HISTORY', id: id, itemHistory: response.data });
                            api.invoicesDetail(id).then(response => {
                                dispatch({ type: 'RECEIVE_INVOICES', id: id, invoices: response.data });
                                api.itemtroubleticketDetail(id).then(response => {
                                    dispatch({ type: 'RECEIVE_TROUBLE_TICKETS', id: id, tickets: response.data });
                                    api.serviceplansDetail(id).then(response => {
                                        dispatch({ type: 'RECEIVE_SERVICE_PLANS', id: id, servicePlans: response.data });
                                    })
                                })
                            })
                        })
                    })
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
    rooms: [],
    invoices: [],
    troubleTickets: [],
    servicePlans: []
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
                invoices: state.invoices,
                itemHistory: state.itemHistory,
                troubleTickets: state.troubleTickets,
                servicePlans: state.servicePlans
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
                    invoices: state.invoices,
                    itemHistory: state.itemHistory,
                    troubleTickets: state.troubleTickets,
                    servicePlans: state.servicePlans
                };
            }
            break;
        case 'REQUEST_PROJECT_ROOMS':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                invoices: state.invoices,
                itemHistory: state.itemHistory,
                troubleTickets: state.troubleTickets,
                servicePlans: state.servicePlans
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
                    invoices: state.invoices,
                    itemHistory: state.itemHistory,
                    troubleTickets: state.troubleTickets,
                    servicePlans: state.servicePlans
                };
            }
            break;
        case 'REQUEST_ITEM_HISTORY':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                invoices: state.invoices,
                itemHistory: state.itemHistory,
                troubleTickets: state.troubleTickets,
                servicePlans: state.servicePlans
            };
        case 'RECEIVE_ITEM_HISTORY':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: state.project,
                    isLoading: true,
                    rooms: state.rooms,
                    invoices: state.invoices,
                    itemHistory: action.itemHistory,
                    troubleTickets: state.troubleTickets,
                    servicePlans: state.servicePlans
                };
            }
            break;
        case 'REQUEST_INVOICES':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                invoices: state.invoices,
                itemHistory: state.itemHistory,
                troubleTickets: state.troubleTickets,
                servicePlans: state.servicePlans
            };
        case 'RECEIVE_INVOICES':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: state.project,
                    isLoading: true,
                    rooms: state.rooms,
                    invoices: action.invoices,
                    itemHistory: state.itemHistory,
                    troubleTickets: state.troubleTickets,
                    servicePlans: state.servicePlans
                };
            }
            break;
        case 'REQUEST_TROUBLE_TICKETS':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                invoices: state.invoices,
                itemHistory: state.itemHistory,
                troubleTickets: state.troubleTickets,
                servicePlans: state.servicePlans
            };
        case 'RECEIVE_TROUBLE_TICKETS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: state.project,
                    isLoading: true,
                    rooms: state.rooms,
                    invoices: state.invoices,
                    itemHistory: state.itemHistory,
                    troubleTickets: action.tickets,
                    servicePlans: state.servicePlans
                };
            }
            break;
        case 'REQUEST_SERVICE_PLANS':
            return {
                id: action.id,
                project: state.project,
                isLoading: true,
                rooms: state.rooms,
                invoices: state.invoices,
                itemHistory: state.itemHistory,
                troubleTickets: state.troubleTickets,
                servicePlans: state.servicePlans
            };
        case 'RECEIVE_SERVICE_PLANS':
            // Only accept the incoming data if it matches the most recent request. This ensures we correctly
            // handle out-of-order responses.
            if (action.id === state.id) {
                return {
                    id: action.id,
                    project: state.project,
                    isLoading: false,
                    rooms: state.rooms,
                    invoices: state.invoices,
                    itemHistory: state.itemHistory,
                    troubleTickets: state.troubleTickets,
                    servicePlans: action.servicePlans
                };
            }
            break;
    }

    return state;
};
