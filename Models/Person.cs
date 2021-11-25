using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Tuition.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20), Required, DisplayName("First Name")]
        public string FirstName { get; set; }

        [StringLength(20), Required, DisplayName("Last Name")]
        public string LastName { get; set; }

        [StringLength(15), Required, DisplayName("Mobile")]
        public string MobileNumber { get; set; }

        public int AddressId { get; set; }

        //Navigation property
        public virtual Address Address { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }


    }
}
