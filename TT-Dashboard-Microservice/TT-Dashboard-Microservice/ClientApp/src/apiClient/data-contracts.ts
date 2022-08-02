/* eslint-disable */
/* tslint:disable */
/*
 * ---------------------------------------------------------------
 * ## THIS FILE WAS GENERATED VIA SWAGGER-TYPESCRIPT-API        ##
 * ##                                                           ##
 * ## AUTHOR: acacode                                           ##
 * ## SOURCE: https://github.com/acacode/swagger-typescript-api ##
 * ---------------------------------------------------------------
 */

export interface EmployeeDto {
  /** @format int32 */
  employeeId?: number;
  fullName?: string | null;
}

export interface InvoiceDto {
  id?: string | null;

  /** @format double */
  total?: number;

  /** @format double */
  appliedAmount?: number;
  timeCreated?: string | null;
  txnDate?: string | null;

  /** @format double */
  daysSinceInvoice?: number;
}

export interface ItemHistoryDto {
  /** @format int32 */
  id?: number;

  /** @format int32 */
  type?: number;
  message?: string | null;
  author?: string | null;

  /** @format int32 */
  authorId?: number;
  timeStamp?: string | null;
}

export interface ItemTroubleTicketDto {
  /** @format int32 */
  id?: number;
  title?: string | null;
  statusString?: string | null;
  dateCreated?: string | null;
  dateDue?: string | null;
  dateClosed?: string | null;
  assignedToList?: string | null;
}

export interface LoginModel {
  user: string;
  pass: string;
}

export interface ProjectCustomerDto {
  /** @format int32 */
  customerId?: number;
  name?: string | null;
}

export interface ProjectDto {
  /** @format int32 */
  projectId?: number;
  name?: string | null;
  customer?: ProjectCustomerDto;

  /** @format date-time */
  start?: string | null;

  /** @format date-time */
  completion?: string | null;
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

  /** @format double */
  codingBudget?: number | null;

  /** @format double */
  codingActual?: number | null;

  /** @format double */
  expenseBudget?: number | null;

  /** @format double */
  laborBudget?: number | null;

  /** @format double */
  laborActual?: number | null;

  /** @format double */
  productBudget?: number | null;

  /** @format double */
  productActual?: number | null;
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
  /** @format double */
  amountInvoiced?: number;

  /** @format double */
  amountOutstanding?: number;

  /** @format double */
  laborActual?: number;
  accountingStatus?: string | null;
}

export interface ProjectProductDto {
  received?: boolean;

  /** @format int32 */
  projectProductId?: number;
  description?: string | null;

  /** @format int32 */
  status?: number;

  /** @format int32 */
  quantity?: number;
  binNumber?: string | null;
  vendor?: string | null;
  trackingNumber?: string | null;

  /** @format double */
  quotePrice?: number | null;

  /** @format double */
  price?: number | null;
  manufacturer?: string | null;
  partNumber?: string | null;

  /** @format date-time */
  eta?: string | null;
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
  /** @format int32 */
  projectRoomId?: number;

  /** @format int32 */
  roomId?: number;
  roomName?: string | null;
  isActive?: boolean;
  products?: ProjectProductDto[] | null;
}

export interface ProjectStartStopDateDto {
  /** @format int32 */
  projectStartStopDateId?: number;

  /** @format int32 */
  projectId?: number;

  /** @format date-time */
  startDate?: string | null;

  /** @format date-time */
  endDate?: string | null;
  description?: string | null;
}
