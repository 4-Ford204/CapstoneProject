﻿using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}