import { axiosClient } from 'src/lib/axios'
import { IDefaultQuery, IResponse } from 'src/types'
import { IVenue } from 'src/types/venue'

export type IGetBookResponse = IResponse<IVenue>

export type GetManyVenuesParams = {
  category?: string[]
  subcategory?: string[]
} & Partial<IDefaultQuery>
async function venueApi(params: GetManyVenuesParams) {
  try {
    const response = await axiosClient.get(`VenuesAPI/GetVenueDTOs/${params.PageIndex}/${params.PageSize}`, {
      params,
    })
    return response.data
  } catch (error) {
    console.error('Error fetching venues:', error)
    throw error
  }
}

export { venueApi }
