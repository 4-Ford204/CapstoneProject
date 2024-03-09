import { User } from './user'
type TimeOnly = string

export interface IVenue {
  Id: string
  Name: string
  Image: string
  Street: string
  Location: string
  GeoLocation: string
  OpenTime: TimeOnly
  CloseTime: TimeOnly
  LowerPrice: number
  UpperPrice: number
  Reviews?: IReview[]
}

export interface IReview {
  Id: string
  product_id: string
  user_id: Pick<User, 'Id' | 'Email' | 'Image' | 'FullName'>
  title?: string
  details?: string
  rating?: number
  voteCount?: number
  status?: string
  purchasesVerify?: string
  createdAt?: string
  updatedAt?: string
}
