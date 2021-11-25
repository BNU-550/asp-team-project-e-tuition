using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Tuition.Models
{
    /// <summary>
    /// This lesson will be deliverd in a particular time slot
    /// by a tutor with a student payed for by a parent.
    /// </summary>
    public class Lesson
    {
        public int LessonId { get; set; }

        public int TimeSlotId { get; set; }

        [Required, DisplayName("Parent")]
        public int PersonId { get; set; }

        [Required, DisplayName("Student")]
        public int StudentId { get; set; }

        public DateTime StartDate { get; set; }

        public int NoRepeat { get; set; }

        public int KeyStage { get; set; }

        public bool FaceToFace { get; set; }

        public bool Online { get; set; }

        //navigation property
        public Person Parent { get; set; }

        public Person Student { get; set; }
    }
}
