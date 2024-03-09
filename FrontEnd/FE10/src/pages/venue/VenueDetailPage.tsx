import React, { useState, useEffect } from 'react'
import { format, parseISO } from 'date-fns'
import { Rating } from '@smastrom/react-rating'
import { IVenue, IReview } from 'src/types/venue'
import { useParams } from 'react-router-dom'
import { getVenueId } from 'src/api/venue/getById'

// Giả mạo dữ liệu đánh giá
const fakeReviews: IReview[] = [
  {
    _id: '1',
    user_id: {
      _id: '1',
      fullName: 'John Doe',
      email: 'john@example.com',
      avatar: 'fake-avatar-url',
    },
    rating: 4,
    updatedAt: '2024-02-27T08:00:00Z',
    details: 'A great place to visit!',
  },
  {
    _id: '2',
    user_id: {
      _id: '2',
      fullName: 'Jane Smith',
      email: 'jane@example.com',
      avatar: 'fake-avatar-url',
    },
    rating: 5,
    updatedAt: '2024-02-25T08:00:00Z',
    details: 'Highly recommended!',
  },
  {
    _id: '3',
    user_id: {
      _id: '2',
      fullName: 'Jane Smith',
      email: 'jane@example.com',
      avatar: 'fake-avatar-url',
    },
    rating: 5,
    updatedAt: '2024-02-25T08:00:00Z',
    details: 'Highly recommended!',
  },
]

function VenueDetailPage() {
  const { id } = useParams<{ id?: string }>()
  const [venue, setVenue] = useState<IVenue | null>(null)
  const [reviewText, setReviewText] = useState<string>('')

  useEffect(() => {
    const fetchVenue = async () => {
      try {
        const venueData = await getVenueId(id) // Lấy dữ liệu venue từ API thật
        setVenue(venueData.Data)
      } catch (error) {
        console.error('Error fetching venue:', error)
      }
    }

    if (id) {
      fetchVenue()
    }
  }, [id])

  const [reviews, setReviews] = useState<IReview[]>(fakeReviews) // Sử dụng dữ liệu giả mạo cho reviews

  const handleReviewSubmit = () => {
    const currentDate = new Date()
    const formattedDate = format(currentDate, "yyyy-MM-dd'T'HH:mm:ss'Z'")

    const review: IReview = {
      _id: (venue?.Reviews?.length || 0 + 1).toString(),
      user_id: {
        fullName: 'John Doe', // Replace with actual user data from authentication
        email: 'john@example.com',
        avatar: 'fake-avatar-url',
      },
      rating: 5, // Replace with actual user rating input
      updatedAt: formattedDate,
      details: reviewText,
    }

    // Update venue with the new review
    setVenue((prevVenue) => {
      const updatedReviews = prevVenue?.Reviews ? [...prevVenue.Reviews, review] : [review]
      return { ...prevVenue, Reviews: updatedReviews }
    })

    // Clear review text input
    setReviewText('')
  }

  return (
    <div className="mx-auto min-h-screen w-full bg-gray-200">
      <div className="mx-auto max-w-6xl bg-white px-2 sm:px-4 lg:px-6">
        <div className="mx-auto max-w-2xl py-1 sm:py-2 lg:max-w-none lg:py-4">
          {venue && (
            <section className="grid w-full grid-cols-1 place-items-start gap-4 py-2 md:grid-cols-3 md:gap-6">
              <article className="ml-7 flex flex-col">
                <img
                  src={venue.Image}
                  alt={venue.Name}
                  className="h-full w-full rounded-sm object-cover shadow-md"
                  style={{ aspectRatio: '1/1' }}
                />
              </article>

              <article className="col-span-2 ml-24 space-y-8 rounded-lg">
                <div className="space-y-4">
                  <h3 className="text-3xl font-medium tracking-wide">{venue.Name}</h3>
                  <div className="flex flex-row justify-between">
                    <div className="flex flex-row">
                      <p className="nav-link mr-4 pr-2">{venue.GeoLocation}</p>
                      <p className="nav-link mr-4 pr-2">{venue.OpenTime}</p>
                      <p className="nav-link mr-4 pr-2">{venue.CloseTime}</p>
                    </div>
                    <div>
                      <button className="rounded bg-blue-500 px-3 py-1 font-bold text-white hover:bg-blue-700">
                        Report
                      </button>
                    </div>
                  </div>
                </div>

                <div className="space-y-6 px-6">
                  <h1 className="text-xl">
                    <span className="font-bold">Đường {venue.Street}</span>
                  </h1>
                  <h1 className="text-xl">
                    <span>{venue.Location}</span>
                  </h1>
                </div>

                <div className="space-y-2 px-6">
                  <span>LowerPrice {venue.LowerPrice} VNĐ</span>
                </div>
                <div className="space-y-2 px-6">
                  <span>UpperPrice {venue.UpperPrice} VNĐ</span>
                </div>
              </article>
            </section>
          )}
        </div>
      </div>

      {/* Phần hiển thị đánh giá */}
      <div className="mx-auto my-2 max-w-6xl bg-white px-2 sm:my-4 sm:px-4 lg:my-6 lg:px-6">
        <div className="mx-auto max-w-2xl py-1 sm:py-2 lg:max-w-none lg:py-4">
          <section key={'main.reviews'} className="w-full py-10">
            <h3 className="mb-8 text-3xl font-medium">Reviewers</h3>
            <div className="my-4 space-y-8">
              {reviews.map((review) => (
                <div key={review._id} className="mb-2 w-full">
                  <div className="flex w-full items-center gap-3">
                    <div>
                      <img
                        src={review.user_id.avatar}
                        alt={review.user_id.fullName}
                        className="h-10 w-10 rounded-full"
                      />
                    </div>
                    <div className="flex flex-1 justify-between gap-4">
                      <div>
                        <div className="text-lg font-medium">{review.user_id.fullName}</div>
                        <div className="text-slate-400">{review.user_id.email}</div>
                      </div>
                      <div className="flex flex-col items-end justify-end">
                        <div className="flex items-center gap-2">
                          <span className="text-lg font-medium">{review.rating}</span>
                          <Rating value={review.rating} />
                        </div>
                        <p className="text-xs text-slate-300">
                          {review.updatedAt
                            ? `Reviewed at ${format(parseISO(review.updatedAt), 'dd/MM/yyyy')}`
                            : 'Review date not available'}
                        </p>
                      </div>
                    </div>
                  </div>
                  <p className="mt-2 w-3/4">{review.details}</p>
                </div>
              ))}
            </div>
          </section>
        </div>
      </div>

      <div className="mx-auto my-2 max-w-6xl bg-white px-2 sm:my-4 sm:px-4 lg:my-6 lg:px-6">
        <div className="mx-auto max-w-2xl py-1 sm:py-2 lg:max-w-none lg:py-4">
          <section key={'main.add-review'} className="w-full py-10">
            <h3 className="mb-8 text-3xl font-medium">Add Review</h3>
            <div className="mb-4">
              <textarea
                className="w-full rounded-md border p-2"
                rows={5}
                placeholder="Write your review here..."
                value={reviewText}
                onChange={(e) => setReviewText(e.target.value)}
              />
            </div>
            <button
              className="rounded bg-blue-500 px-4 py-2 font-bold text-white hover:bg-blue-700"
              onClick={handleReviewSubmit}
            >
              Submit Review
            </button>
          </section>
        </div>
      </div>
    </div>
  )
}

export default VenueDetailPage
