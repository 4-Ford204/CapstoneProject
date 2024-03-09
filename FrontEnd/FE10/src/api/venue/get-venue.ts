import { axiosClient } from 'src/lib/axios'

async function venueApi() {
  try {
    const response = await axiosClient.get('VenuesAPI/GetVenueDTOs/1/30', {})
    return response.data
  } catch (error) {
    console.error('Error fetching venues:', error)
    throw error
  }
}

export { venueApi }
