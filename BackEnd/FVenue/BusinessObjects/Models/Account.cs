﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] SaltPassword { get; set; }
        public string HashPassword { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int LoginMethod { get; set; }
        public bool IsEmailConfirmed { get; set; }
<<<<<<< HEAD
       
=======

        public virtual ICollection<SubCategoryRequest> SubCategoryRequests { get; set; }
>>>>>>> f9ada662a50ff04e125ad295d1becce0cfadc34c
    }
}