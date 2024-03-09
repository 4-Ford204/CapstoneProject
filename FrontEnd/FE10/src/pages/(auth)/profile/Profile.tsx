import { Button } from 'src/components/ui/button'
import { Card, CardContent, CardDescription, CardFooter, CardHeader, CardTitle } from 'src/components/ui/card'
import { Input } from 'src/components/ui/input'
import { Label } from 'src/components/ui/label'
import { Tabs, TabsContent, TabsList, TabsTrigger } from 'src/components/ui/tabs'

function Profile() {
  return (
    <div className="mx-auto max-w-lg">
      <Tabs defaultValue="account" className="w-full">
        <TabsList className="grid w-full grid-cols-2">
          <TabsTrigger value="account">Account</TabsTrigger>
          <TabsTrigger value="password">Password</TabsTrigger>
        </TabsList>
        <TabsContent value="account" className="mt-4">
          <Card className="rounded-lg p-7">
            <CardHeader>
              <CardTitle>Account</CardTitle>
              <CardDescription>Make changes to your account here. Click save when you are done.</CardDescription>
            </CardHeader>
            <CardContent className="space-y-2">
              <div className="space-y-1">
                <Label htmlFor="name">Name</Label>
                <Input id="name" defaultValue="Pedro Quarte" />
              </div>
              <div className="space-y-1">
                <Label htmlFor="name">Gender</Label>
                <Input id="name" defaultValue="Pedro Quarte" />
              </div>
              <div className="space-y-1">
                <Label htmlFor="name">Location</Label>
                <Input id="name" defaultValue="Pedro Quarte" />
              </div>
              <div className="space-y-1">
                <Label htmlFor="name">Phone Number</Label>
                <Input id="name" defaultValue="Pedro Quarte" />
              </div>
              <div className="space-y-1">
                <Label htmlFor="name">Email</Label>
                <Input id="name" defaultValue="Pedro Quarte" />
              </div>
              <div className="space-y-1">
                <Label htmlFor="username">Username</Label>
                <Input id="username" defaultValue="@pedate" />
              </div>
            </CardContent>
            <CardFooter className="mt-4 text-center">
              <Button className="rounded-full">Save changes</Button>
            </CardFooter>
          </Card>
        </TabsContent>
        <TabsContent value="password" className="mt-4">
          <Card className="rounded-lg p-7">
            <CardHeader>
              <CardTitle>Password</CardTitle>
              <CardDescription>Change your password here. After saving, you will be logged out.</CardDescription>
            </CardHeader>
            <CardContent className="space-y-2">
              <div className="space-y-1">
                <Label htmlFor="current">Current password</Label>
                <Input id="current" type="password" />
              </div>
              <div className="space-y-1">
                <Label htmlFor="new">New password</Label>
                <Input id="new" type="password" />
              </div>
            </CardContent>
            <CardFooter className="mt-4 text-center">
              <Button className="rounded-full">Save password</Button>
            </CardFooter>
          </Card>
        </TabsContent>
      </Tabs>
    </div>
  )
}

export default Profile
