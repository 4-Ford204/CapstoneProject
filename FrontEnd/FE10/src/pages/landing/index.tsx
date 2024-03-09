import LandingLayout from '../layout/LandingLayout'
import TopVenue from 'src/components/landing/top-venue'
import CarouselLD from 'src/components/carousel/carousel'
function LandingPage() {
  return (
    <LandingLayout>
      <>
        <div className=" bg-gray-100">
          <CarouselLD />
          <TopVenue />
          <TopVenue />
        </div>
      </>
    </LandingLayout>
  )
}
export default LandingPage
