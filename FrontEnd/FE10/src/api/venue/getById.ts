import { axiosClient } from 'src/lib/axios'

async function getVenueId(venue_Id: string) {
  try {
    const response = await axiosClient.get(`VenuesAPI/GetVenueDTO/${venue_Id}`, {})
    return response.data
  } catch (error) {
    console.error('Error fetching venues:', error)
    throw error
  }
}

export { getVenueId }
