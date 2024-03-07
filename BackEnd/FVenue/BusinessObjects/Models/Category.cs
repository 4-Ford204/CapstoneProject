namespace BusinessObjects.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<SubCategoryRequest> SubCategoryRequests { get; set; }
    }
}
