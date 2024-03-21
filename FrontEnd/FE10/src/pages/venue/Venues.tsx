import { GetManyVenuesParams } from 'src/api/venue/get-venue'
import VenueFilterSidebar from 'src/components/venueSearch/venue-filter-sidebar'
import VenueGridLoading from 'src/components/venueSearch/venue-grid-loading'
// import { IBreadcrumb } from 'src/components/breadcrumb'
// import Breadcrumb from 'src/components/breadcrumb/breadcrumb'
import { Card, CardContent, CardDescription, CardFooter, CardTitle } from 'src/components/ui/card'
import MetaData from 'src/components/metadata'
import Paginition from 'src/components/ui/pagination'
import React from 'react'
import { Link } from 'react-router-dom'
import useGetManyVenues from 'src/pages/venue/useGetManyVenues'

const initVenueState: GetManyVenuesParams = {
  page: 1,
  perPage: 8,
  subcategory: undefined,
  category: undefined,
  reviews: undefined,
  search: undefined,
}

function Venues() {
  // const breadcrumb = React.useMemo<IBreadcrumb[]>(() => {
  //   return [
  //     {
  //       label: 'Home',
  //       key: 'home',
  //       href: '/',
  //       icon: 'smartHome',
  //     },
  //     {
  //       key: 'venues',
  //       label: 'Venues',
  //       href: '/venues',
  //     },
  //   ]
  // }, [])

  const [venueState, setvenueState] = React.useState<GetManyVenuesParams>(initVenueState)
  const { data, isLoading, isError } = useGetManyVenues(venueState, {
    // keepPreviousData: true,
    refetchOnWindowFocus: false,
  })

  React.useEffect(() => {
    console.log('Venue state:', venueState)
    console.log('Data:', data)
  }, [venueState, data])

  const renderVenues = React.useMemo(() => {
    if (isLoading) return <VenueGridLoading pageSize={venueState.perPage!} />
    if (!data) return null
    return data.Data?.Result.map((venue) => {
      return (
        <Link to={`/venue/${venue.Id}`} className="card-link" key={venue.Id}>
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
      )
    })
  }, [venueState.perPage, data, isLoading])
  const totalPage = React.useMemo(() => {
    return data?.Data?.TotalPages || 1
  }, [data?.Data?.TotalPages])

  if (isError) return <div>Something went wrong</div>
  return (
    <main className="container mx-auto grid min-h-screen w-full place-items-center">
      <MetaData title="Venues" />
      {/* <Breadcrumb items={breadcrumb} className="my-8 w-full" /> */}
      <div className="flex w-full gap-2">
        <section key="main.section.sidebar" className="sticky top-20 h-min w-1/4 rounded-md bg-accent px-4 py-5">
          <VenueFilterSidebar
            onFilterChange={(data) => {
              setvenueState((prev) => ({
                ...prev,
                ...data,
              }))
            }}
          />
        </section>
        <section key="main.section.Venues" className="grid flex-1 grid-cols-4 gap-5">
          {renderVenues}
          <div className="col-span-full mx-auto w-fit">
            <Paginition
              currentPage={venueState.page || 1}
              totalPage={totalPage}
              onPageChange={(page) => {
                setvenueState((prev) => ({
                  ...prev,
                  page,
                }))
              }}
              onPreviousPage={() => {
                setvenueState((prev) => ({
                  ...prev,
                  page: prev.page! - 1,
                }))
              }}
              onNextPage={() => {
                setvenueState((prev) => ({
                  ...prev,
                  page: prev.page! + 1,
                }))
              }}
            />
          </div>
        </section>
      </div>
    </main>
  )
}

export default Venues
