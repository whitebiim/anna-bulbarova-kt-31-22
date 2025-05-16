﻿using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    // Преподаватели
    public class Teacher
    {

        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
        public int? PositionId { get; set; }
        public Position Position { get; set; }
        public int? AcademicDegreeId { get; set; }
        public AcademicDegree AcademicDegree { get; set; }
        public int? TeachingLoadId { get; set; }
        public TeachingLoad TeachingLoad { get; set; }
    }
}
