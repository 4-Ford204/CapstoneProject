import React from 'react'
import { createBrowserRouter } from 'react-router-dom'
const MainLayout = React.lazy(() => import('../pages/layout/MainLayout'))
const LandingPage = React.lazy(() => import('src/pages/landing'))
const BookPage = React.lazy(() => import('src/pages/book/BookPage'))
const VenueDetailPage = React.lazy(() => import('src/pages/venue/VenueDetailPage'))
const AuthLayout = React.lazy(() => import('src/pages/layout/AuthLayout'))
const LoginPage = React.lazy(() => import('src/pages/(auth)/login/SignInPage'))
const SignUpPage = React.lazy(() => import('src/pages/(auth)/register/SignUpPage'))
const Profile = React.lazy(() => import('src/pages/(auth)/profile/Profile'))

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
      {
        path: '/profile',
        element: <Profile />,
      },
    ],
  },
])
