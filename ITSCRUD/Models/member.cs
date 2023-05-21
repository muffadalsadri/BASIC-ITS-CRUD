using System.ComponentModel.DataAnnotations;


namespace ITSCRUD.Models
{
    public class member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Member Name")]
        public string Name { get; set; }
        public int ITS { get; set; }
        public string Jamaat { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
