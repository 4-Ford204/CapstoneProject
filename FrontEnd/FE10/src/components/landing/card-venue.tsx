import { Link } from 'react-router-dom'
import { Card, CardContent, CardDescription, CardFooter, CardTitle } from '../ui/card'
import { IVenue } from 'src/types/venue'

type Props = { venue: IVenue }
function Venue({ venue }: Props) {
  return (
    <div>
      <Link to={`/venue/${venue.Id}`} key={venue.Id}>
        <Card className=" h-full lg:w-[14.5rem]">
          <CardTitle className="aspect-[1] flex-col overflow-clip rounded-bl-none rounded-br-none rounded-tl-md rounded-tr-md  border-transparent p-0 shadow-md transition-all duration-300 group-hover:shadow-xl">
            <img
              src={venue.Image}
              alt={venue.Name}
              className="aspect-[1] object-cover transition-all duration-300"
              style={{ width: '100%', height: '100%', maxWidth: '100%', maxHeight: '100%' }}
            />
          </CardTitle>
          <CardContent className="p-0 lg:p-2 lg:text-lg">
            <strong>{venue.Name}</strong>
            <CardDescription className=" text-blue-500">{venue.Street ? venue.Street : 'NA'}</CardDescription>
            <CardDescription>{venue.Location}</CardDescription>
          </CardContent>
          <CardFooter className="bottom-0 bg-gray-100 p-2 text-red-700">
            Price Range: {venue.LowerPrice}VNĐ - {venue.UpperPrice}VNĐ
          </CardFooter>
        </Card>
      </Link>
    </div>
  )
}

export default Venue
