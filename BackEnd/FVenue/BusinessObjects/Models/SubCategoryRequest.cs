using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    public class SubCategoryRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Account")]
        public int RequestUserId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? AdministratorId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int Status { get; set; }
    }
}
