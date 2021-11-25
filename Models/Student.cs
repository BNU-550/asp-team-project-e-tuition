using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Tuition.Models
{
    public class Student:Person
    {
        [DisplayName("Key Stage"), Range(1, 4)]
        public int KeyStage { get; set; } = 4;

        [DisplayName("Subject")]
        public int Subjects { get; set; }

        public int ParentId { get; set; }

        public int TutorId { get; set; }

    }
}
