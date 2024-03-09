export type IResponse<T> = {
  Data?: {
    PageIndex: number
    PageSize: 30
    TotalPages: 2
    Result: T
  }
  Message?: string
  Code?: number
  _pagination?: {
    total: number
    totalPage: number
  }
}

export type IErrorResponse = {
  message: string
}
