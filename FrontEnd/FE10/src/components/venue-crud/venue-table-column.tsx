import { ColumnDef } from '@tanstack/react-table'
import { Button } from 'src/components/ui/button'
import { IVenue } from 'src/types/venue'

export const columns: ColumnDef<IVenue>[] = [
  {
    accessorKey: 'Name',
    header: 'Name',
    cell({ getValue }) {
      const name: string = getValue() as string
      return <p className="max-w-[30rem] text-slate-400">{name}</p>
    },
  },
  {
    accessorKey: 'Image',
    header: 'Image',
    cell({ getValue }) {
      const Image: string = getValue() as string
      return <img src={Image} className=" h-[8rem] max-w-[10rem] text-slate-400"></img>
    },
  },
  {
    accessorKey: 'Street',
    header: 'Street',
    cell({ getValue }) {
      const Street: string = getValue() as string
      return <p className="max-w-[30rem] text-black">{Street}</p>
    },
  },
  {
    accessorKey: 'Street',
    header: 'Street',
    cell({ getValue }) {
      const Street: string = getValue() as string
      return <p className="max-w-[30rem] text-black">{Street}</p>
    },
  },
  {
    accessorKey: 'Street',
    header: 'Street',
    cell({ getValue }) {
      const Street: string = getValue() as string
      return <p className="max-w-[30rem] text-black">{Street}</p>
    },
  },
  {
    accessorKey: 'Street',
    header: 'Street',
    cell({ getValue }) {
      const Street: string = getValue() as string
      return <p className="max-w-[30rem] text-black">{Street}</p>
    },
  },
  {
    accessorFn: ({ Id }) => Id,
    header: 'Action',
    cell() {
      return (
        <div className="flex gap-2 ">
          <Button variant="outline" size="sm">
            Edit
          </Button>
          <Button variant="outline" size="sm">
            Delete
          </Button>
        </div>
      )
    },
  },
]
