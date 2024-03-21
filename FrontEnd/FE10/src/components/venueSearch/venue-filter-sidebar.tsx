import { zodResolver } from '@hookform/resolvers/zod'
import { useForm } from 'react-hook-form'
import { useSearchParams } from 'react-router-dom'
import useGetAllCategory from 'src/pages/venue/useGetManyCategory'
import { z } from 'zod'
import { IComboboxData } from '../ui/combobox'
import React, { useEffect, useMemo, useState } from 'react'
import { Button } from '../ui/button'
import { Input } from '../ui/input'
import { Label } from '../ui/label'
import { Select, SelectContent, SelectItem, SelectTrigger, SelectValue } from '../ui/selector'
import { Separator } from '../ui/separator'
import { SearchCategory } from './search-categories'

type Props = {
  onFilterChange?: (filter: Record<string, unknown>) => void
  totalVenues?: number
  onRentAll?: () => void
}

const FilterSchema = z.object({
  search: z.string().optional(),
  category: z.string().optional(),
  minPrice: z.string().optional(),
  maxPrice: z.string().optional(),
  rating: z.string().optional(),
  subcategory: z.string().optional(),
})
type FilterForm = z.infer<typeof FilterSchema>
function BookFilterSideBar({ onFilterChange, totalVenues }: Props) {
  const [searchParams, setSearchParams] = useSearchParams()
  const { control, handleSubmit, reset, setValue, watch } = useForm<FilterForm>({
    resolver: zodResolver(FilterSchema),
  })
  const { isLoading: isCategoryLoading, data: categories } = useGetAllCategory()
  console.log('categories', categories)
  const categoriesCombobox = useMemo(() => {
    if (!categories) return []
    else
      return categories.map<IComboboxData>((ct) => ({
        label: ct.Name,
        value: ct.Id || '',
      }))
  }, [categories])

  useEffect(() => {
    const search = searchParams.get('search') || ''
    const minPrice = searchParams.get('minPrice') || ''
    const maxPrice = searchParams.get('maxPrice') || ''
    const rating = searchParams.get('rating') || ''
    const category = searchParams.get('category') || ''
    const subcategory = searchParams.get('subcategory') || ''

    setValue('search', search)
    setValue('category', category)
    setValue('minPrice', minPrice)
    setValue('maxPrice', maxPrice)
    setValue('rating', rating)
    setValue('subcategory', subcategory)

    control.handleSubmit((data) => {
      onFilterChange && onFilterChange(data)
    })()
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [searchParams])
  const onSubmit = React.useCallback(
    (data: FilterForm) => {
      const searchParams = new URLSearchParams()

      data.search && searchParams.set('search', data.search)
      data.category && searchParams.set('category', data.category)
      data.minPrice && searchParams.set('minPrice', data.minPrice)
      data.maxPrice && searchParams.set('maxPrice', data.maxPrice)
      data.rating && searchParams.set('rating', data.rating)
      data.subcategory && searchParams.set('subcategory', data.subcategory)

      setSearchParams(searchParams, { replace: true })

      if (onFilterChange) {
        onFilterChange(data)
      }
    },
    [onFilterChange, setSearchParams],
  )
  const [clearFlag, setClearFlag] = useState(false)
  const onClear = React.useCallback(() => {
    reset()
    setClearFlag((prev) => !prev)
  }, [reset])

  return (
    <React.Fragment key={'sidebar.filter'}>
      {totalVenues && <p className="text-sm text-slate-500">{totalVenues} venues found</p>}
      <form onSubmit={handleSubmit(onSubmit)} className="space-y-8">
        <div>
          <span className="my-2 flex flex-row items-center py-3">
            <p className="pl-2 text-lg font-extrabold">Tìm kiếm </p>
          </span>
          <Separator />
          <div aria-label="search">
            <Label htmlFor="search">Tìm địa điểm</Label>
            <Input placeholder="nhập tên địa điểm" id="search" {...control.register('search')} className="bg-card" />
          </div>
          <div>
            <Label htmlFor="category">Thể loại</Label>
            <SearchCategory
              isLoading={isCategoryLoading}
              data={categoriesCombobox}
              defaultValue={watch('category')}
              onSelection={(category) => setValue('category', category)}
              clear={clearFlag}
            />
          </div>
          <div>
            <Label htmlFor="Chi tiết loại hình">Chi tiết</Label>
            <Select
              onValueChange={(value) => {
                setValue('subcategory', value)
              }}
              value={watch('subcategory')}
            >
              <SelectTrigger>
                <SelectValue placeholder="Chi tiết loại hình" />
              </SelectTrigger>
              <SelectContent>
                <SelectItem className="hover:bg-accent" value="bánh xèo">
                  bánh xèo
                </SelectItem>
                <SelectItem className="hover:bg-accent" value=" karaoke">
                  karaoke
                </SelectItem>
              </SelectContent>
            </Select>
          </div>
          <div>
            <Label htmlFor="price">Giá</Label>
            <div className="-center flex flex-row">
              <Input placeholder="Từ" id="minPrice" {...control.register('minPrice')} className="bg-card" />
              <p className="p-2">-</p>
              <Input placeholder="Từ" id="maxPrice" {...control.register('maxPrice')} className="bg-card" />
            </div>
          </div>
          <div>
            <Label htmlFor="rating">Đánh giá</Label>
            <Select
              onValueChange={(value) => {
                setValue('rating', value)
              }}
              value={watch('rating')}
            >
              <SelectTrigger>
                <SelectValue placeholder="Choose Rating" />
              </SelectTrigger>
              <SelectContent>
                <SelectItem className="hover:bg-accent" value="1">
                  <p className="flex-row">1 *</p>
                </SelectItem>
                <SelectItem className="hover:bg-accent" value="2">
                  <p className="flex-row">2 *</p>
                </SelectItem>
                <SelectItem className="hover:bg-accent" value="3">
                  <p className="flex-row">3 *</p>
                </SelectItem>
                <SelectItem className="hover:bg-accent" value="4">
                  <p className="flex-row">4 *</p>
                </SelectItem>
                <SelectItem className="hover:bg-accent" value="5">
                  <p className="flex-row">5 *</p>
                </SelectItem>
              </SelectContent>
            </Select>
          </div>
        </div>
        <Separator />
        <div className="flex justify-between">
          <Button type="submit">Tìm ngay</Button>
          <Button variant={'ghost'} type="button" onClick={onClear} className="">
            xoá
          </Button>
        </div>
      </form>
    </React.Fragment>
  )
}
export default BookFilterSideBar
