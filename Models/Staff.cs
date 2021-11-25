using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Tuition.Models
{
    public class Staff:Person
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Currency), Required]
        public decimal Salary { get; set; }

        [DisplayName("Job Title")]
        public int JobTitle { get; set; }
    }
}
