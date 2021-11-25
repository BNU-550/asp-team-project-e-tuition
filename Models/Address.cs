using System.ComponentModel.DataAnnotations;

namespace E_Tuition.Models
{
    public class Address:Person
    {
        public int Id { get; set; }

        public int PaymentId { get; set; }
        
        [StringLength(20), Required]
        public string HouseNumber { get; set; }

        [StringLength(10), Required]
        public string PostCode { get; set; }
    }
}
