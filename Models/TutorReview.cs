using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Tuition.Models
{
    public class TutorReview:Person
    {
        [StringLength(500), DisplayName("Review"), DataType(DataType.MultilineText)]
        public string ReviewText { get; set; }

        [DisplayName("Rating")]
        public int Rating { get; set; }

        public int PersonId { get; set; }

        public int TutorId { get; set; }
    }
}
