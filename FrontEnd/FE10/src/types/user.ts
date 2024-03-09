export interface User {
  Id?: string
  Email?: string
  FullName?: string
  RoleName?: 'MANAGER' | 'USER'
  PhoneNumber?: string
  Image?: string
  CreateDate?: string | null
  LastUpdateDate?: string | null
  FirstName?: string
  LastName?: string
  password?: string
  passwordAttempt?: number
  salt?: string
}

export enum ROLE {
  MANAGER = 'MANAGER',
  CUSTOMER = 'USER',
}
