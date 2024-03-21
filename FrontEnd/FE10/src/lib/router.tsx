import React from 'react'
import { createBrowserRouter } from 'react-router-dom'
const VenueTable = React.lazy(() => import('src/components/venue-crud/venue-table'))
const MainLayout = React.lazy(() => import('../pages/layout/MainLayout'))
const LandingPage = React.lazy(() => import('src/pages/landing'))
const VenueDetailPage = React.lazy(() => import('src/pages/venue/VenueDetailPage'))
const AuthLayout = React.lazy(() => import('src/pages/layout/AuthLayout'))
const LoginPage = React.lazy(() => import('src/pages/(auth)/login/SignInPage'))
const SignUpPage = React.lazy(() => import('src/pages/(auth)/register/SignUpPage'))
const Profile = React.lazy(() => import('src/pages/(auth)/profile/Profile'))
const Venues = React.lazy(() => import('src/pages/venue/Venues'))

export const ROUTES = createBrowserRouter([
  {
    element: <MainLayout />,
    children: [
      {
        path: '/',
        element: <LandingPage />,
      },
    ],
  },
  {
    path: '/venue/:id',
    element: <VenueDetailPage />,
  },
  {
    path: '/venues',
    element: <Venues />,
  },
  {
    path: '/profile',
    element: <Profile />,
  },
  {
    path: '/venueManager',
    element: <VenueTable />,
  },

  {
    element: <AuthLayout />,
    children: [
      {
        path: '/login',
        element: <LoginPage />,
      },
      {
        path: '/register',
        element: <SignUpPage />,
      },
    ],
  },
])
