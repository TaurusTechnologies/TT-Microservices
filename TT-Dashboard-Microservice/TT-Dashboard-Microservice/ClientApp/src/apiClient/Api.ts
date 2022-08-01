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

import { LoginModel } from "./data-contracts";
import { ContentType, HttpClient, RequestParams } from "./http-client";

export class Api<SecurityDataType = unknown> extends HttpClient<SecurityDataType> {
  /**
   * No description
   *
   * @tags Auth
   * @name AuthLoginCreate
   * @request POST:/api/Auth/Login
   * @secure
   */
  authLoginCreate = (data: LoginModel, params: RequestParams = {}) =>
    this.request<void, any>({
      path: `/api/Auth/Login`,
      method: "POST",
      body: data,
      secure: true,
      type: ContentType.Json,
      ...params,
    });
  /**
   * No description
   *
   * @tags Auth
   * @name AuthGetList
   * @request GET:/api/Auth/Get
   * @secure
   */
  authGetList = (params: RequestParams = {}) =>
    this.request<string[], any>({
      path: `/api/Auth/Get`,
      method: "GET",
      secure: true,
      format: "json",
      ...params,
    });
}
