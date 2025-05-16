﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    // Должности
    public class Position
    {
        public enum PositionNameType
        {
            [Display(Name = "Преподаватель")]
            Lecturer,

            [Display(Name = "Старший преподаватель")]
            HeadLecturer,

            [Display(Name = "Доцент")]
            Docent,

            [Display(Name = "Профессор")]
            Professor,
        }
        public int PositionId { get; set; }
        public PositionNameType PositionName { get; set; }
    }
}
