using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    // Ученые степени
    public class AcademicDegree
    {
        public enum AcademicDegreeNameTypes
        {
            [Display(Name = "Кандидат наук")]
            ScienceCandidate,
            [Display(Name = "Доктор наук")]
            ScienceDoctor,
        }

        public int AcademicDegreeId { get; set; }
        public AcademicDegreeNameTypes AcademicDegreeName { get; set; }
    }
}
