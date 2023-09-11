using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MemoMates.Classes.DB.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ListId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; } = null;
        [StringLength(200)]
        public string PhoneNumber { get; set; } = null;
        [StringLength(500)]
        public string EmailAddress { get; set; } = null;
        [StringLength(5000)]
        public string ExtraInfo { get; set; } = null;
        public DateTime? DateOfBirth { get; set; } = null;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual PersonList List { get; set; }

        public string FullName()
        {
            return $"{this.FirstName} {this.LastName} {this.MiddleName}".Trim();
        }
    }
}
