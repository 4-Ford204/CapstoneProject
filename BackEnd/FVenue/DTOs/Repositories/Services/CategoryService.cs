﻿using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
            using (var _context = new DatabaseContext())
            {
                var categories = _context.Categories.ToList();
                return categories;
            }
        }

        public int GetVenueNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var subCategories = _context.SubCategories.Where(x => x.CategoryId == id).ToList();
                var venueNumber = subCategories.Join(_context.VenueSubCategories,
                    subCategory => subCategory.Id,
                    venueSubCategory => venueSubCategory.SubCategoryId,
                    (subCategory, venueSubCategory) => venueSubCategory.VenueId)
                    .Count();
                return venueNumber;
            }
        }
    }
}
