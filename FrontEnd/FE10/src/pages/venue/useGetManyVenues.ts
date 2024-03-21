import { venueApi, GetManyVenuesParams } from 'src/api/venue/get-venue'
import { IVenue, IResponse } from 'src/types'
import { useQuery, UseQueryOptions, UseQueryResult } from '@tanstack/react-query'

export default function useGetManyVenues(
  params: GetManyVenuesParams,
  options?: Omit<UseQueryOptions<IResponse<IVenue[]>, unknown>, 'queryKey'>,
): UseQueryResult<IResponse<IVenue[]>, unknown> {
  console.log('Params:', params)
  return useQuery(['venues', params], () => venueApi(params), options)
}
