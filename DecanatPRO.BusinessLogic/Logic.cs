using DecanatPRO.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace DecanatPRO.BusinessLogic
{
    public class Logic
    {
        public List<Student> Students {get;set;} = new List<Student>();
        public void AddStudent(string name, string speciality, string group)
        {
            Students.Add(new Student
            {
                Name = name,
                Speciality = speciality,
                Group = group
            });
        }
        public void DeleteStudent (string name, string speciality, string group)
        {
            var studentToRemove = Students.FirstOrDefault(s => s.Name == name && s.Speciality == speciality && s.Group == group);
            if (studentToRemove !=null)
            {
                Students.Remove(studentToRemove);
            }
        }
        public List<Student> GetAllStudents()
        {
            return Students;
        }
        public Dictionary<string, int> GetSpecialityDistribution()
        {
            return Students
                .GroupBy(s => s.Speciality)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
