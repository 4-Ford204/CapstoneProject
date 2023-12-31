﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual ICollection<VenueSubCategory> VenueSubCategories { get; set; }
    }
}
