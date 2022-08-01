declare namespace Components {
    namespace Schemas {
        export interface EmployeeDto {
            employeeId?: number; // int32
            fullName?: string | null;
        }
        export interface ItemHistoryDto {
            id?: number; // int32
            type?: number; // int32
            message?: string | null;
            author?: string | null;
            authorId?: number; // int32
            timeStamp?: string | null;
        }
        export interface LoginModel {
            user: string;
            pass: string;
        }
        export interface ProjectCustomerDto {
            customerId?: number; // int32
            name?: string | null;
        }
        export interface ProjectDto {
            projectId?: number; // int32
            name?: string | null;
            customer?: ProjectCustomerDto;
            start?: string | null; // date-time
            completion?: string | null; // date-time
            dateDescription?: string | null;
            startStopDates?: ProjectStartStopDateDto[] | null;
            jobNumber?: string | null;
            poNumber?: string | null;
            phoneNumber?: string | null;
            faxNumber?: string | null;
            cellNumber?: string | null;
            contactName?: string | null;
            contactEmail?: string | null;
            installAddress?: ProjectLocationDto;
            shippingAddress?: ProjectLocationDto;
            billingName?: string | null;
            billingEmail?: string | null;
            billingAddress?: ProjectLocationDto;
            notes?: string | null;
            isLegacyServicePlan?: boolean;
            metrics?: ProjectMetricsDto;
            codingBudget?: number | null; // double
            codingActual?: number | null; // double
            expenseBudget?: number | null; // double
            laborBudget?: number | null; // double
            laborActual?: number | null; // double
            productBudget?: number | null; // double
            productActual?: number | null; // double
            leadTech?: EmployeeDto;
        }
        export interface ProjectLocationDto {
            locationName?: string | null;
            address1?: string | null;
            address2?: string | null;
            city?: string | null;
            state?: string | null;
            zip?: string | null;
        }
        export interface ProjectMetricsDto {
            amountInvoiced?: number; // double
            amountOutstanding?: number; // double
            laborActual?: number; // double
        }
        export interface ProjectProductDto {
            received?: boolean;
            projectProductId?: number; // int32
            description?: string | null;
            status?: number; // int32
            quantity?: number; // int32
            binNumber?: string | null;
            vendor?: string | null;
            trackingNumber?: string | null;
            quotePrice?: number | null; // double
            price?: number | null; // double
            manufacturer?: string | null;
            partNumber?: string | null;
            eta?: string | null; // date-time
            poNumber?: string | null;
            orderNotes?: string | null;
        }
        export interface ProjectProductFieldUpdateDto {
            field?: string | null;
            value?: string | null;
        }
        export interface ProjectProductFieldUpdateResultDto {
            success?: boolean;
            msg?: string | null;
        }
        export interface ProjectRoomDto {
            projectRoomId?: number; // int32
            roomId?: number; // int32
            roomName?: string | null;
            isActive?: boolean;
            products?: ProjectProductDto[] | null;
        }
        export interface ProjectStartStopDateDto {
            projectStartStopDateId?: number; // int32
            projectId?: number; // int32
            startDate?: string | null; // date-time
            endDate?: string | null; // date-time
            description?: string | null;
        }
        export interface WeatherForecast {
            date?: string; // date-time
            temperatureC?: number; // int32
            temperatureF?: number; // int32
            summary?: string | null;
        }
    }
}
declare namespace Paths {
    namespace ApiAuthGet {
        namespace Get {
            namespace Responses {
                export type $200 = string[];
            }
        }
    }
    namespace ApiAuthLogin {
        namespace Post {
            export type RequestBody = Components.Schemas.LoginModel;
            namespace Responses {
                export interface $200 {
                }
            }
        }
    }
    namespace ProjectGet {
        namespace Get {
            namespace Parameters {
                export type Id = number; // int32
            }
            export interface QueryParameters {
                id?: Parameters.Id /* int32 */;
            }
            namespace Responses {
                export type $200 = Components.Schemas.ProjectDto;
            }
        }
    }
    namespace ProjectItemhistory$Id {
        namespace Get {
            namespace Parameters {
                export type Id = number; // int32
            }
            export interface PathParameters {
                id: Parameters.Id /* int32 */;
            }
            namespace Responses {
                export type $200 = Components.Schemas.ItemHistoryDto[];
            }
        }
    }
    namespace ProjectProjectproduct$IdField {
        namespace Post {
            namespace Parameters {
                export type Id = number; // int32
            }
            export interface PathParameters {
                id: Parameters.Id /* int32 */;
            }
            export type RequestBody = Components.Schemas.ProjectProductFieldUpdateDto;
            namespace Responses {
                export type $200 = Components.Schemas.ProjectProductFieldUpdateResultDto;
            }
        }
    }
    namespace ProjectRooms$Id {
        namespace Get {
            namespace Parameters {
                export type Id = number; // int32
            }
            export interface PathParameters {
                id: Parameters.Id /* int32 */;
            }
            namespace Responses {
                export type $200 = Components.Schemas.ProjectRoomDto[];
            }
        }
    }
    namespace WeatherForecast {
        namespace Get {
            namespace Responses {
                export type $200 = Components.Schemas.WeatherForecast[];
            }
        }
    }
}
