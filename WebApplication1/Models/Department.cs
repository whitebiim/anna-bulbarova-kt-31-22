using System.Text.RegularExpressions;

namespace WebApplication1.Models
{
    // Кафедры
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public bool IsValidDepartmentName()
        {
            return Regex.IsMatch(DepartmentName, @"\D*");
        }
    }
}
