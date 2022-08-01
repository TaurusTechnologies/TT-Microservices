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

import {
  ItemHistoryDto,
  ProjectDto,
  ProjectProductFieldUpdateDto,
  ProjectProductFieldUpdateResultDto,
  ProjectRoomDto,
} from "./data-contracts";
import { ContentType, HttpClient, RequestParams } from "./http-client";

export class Project<SecurityDataType = unknown> extends HttpClient<SecurityDataType> {
  /**
   * No description
   *
   * @tags Project
   * @name GetProject
   * @request GET:/Project/Get
   * @secure
   */
  getProject = (query?: { id?: number }, params: RequestParams = {}) =>
    this.request<ProjectDto, any>({
      path: `/Project/Get`,
      method: "GET",
      query: query,
      secure: true,
      format: "json",
      ...params,
    });
  /**
   * No description
   *
   * @tags Project
   * @name ProjectproductFieldCreate
   * @request POST:/Project/projectproduct/{id}/field
   * @secure
   */
  projectproductFieldCreate = (id: number, data: ProjectProductFieldUpdateDto, params: RequestParams = {}) =>
    this.request<ProjectProductFieldUpdateResultDto, any>({
      path: `/Project/projectproduct/${id}/field`,
      method: "POST",
      body: data,
      secure: true,
      type: ContentType.Json,
      format: "json",
      ...params,
    });
  /**
   * No description
   *
   * @tags Project
   * @name ItemhistoryDetail
   * @request GET:/Project/itemhistory/{id}
   * @secure
   */
  itemhistoryDetail = (id: number, params: RequestParams = {}) =>
    this.request<ItemHistoryDto[], any>({
      path: `/Project/itemhistory/${id}`,
      method: "GET",
      secure: true,
      format: "json",
      ...params,
    });
  /**
   * No description
   *
   * @tags Project
   * @name RoomsDetail
   * @request GET:/Project/rooms/{id}
   * @secure
   */
  roomsDetail = (id: number, params: RequestParams = {}) =>
    this.request<ProjectRoomDto[], any>({
      path: `/Project/rooms/${id}`,
      method: "GET",
      secure: true,
      format: "json",
      ...params,
    });
}
