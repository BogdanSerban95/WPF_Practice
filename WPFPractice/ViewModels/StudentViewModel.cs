using WPFPractice.Models;
using System.Collections.ObjectModel;

namespace WPFPractice.ViewModels
{
    class StudentViewModel
    {
        public ObservableCollection<Student> Students
        { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Lee" });
            students.Add(new Student { FirstName = "Leonard", LastName = "Cohen" });
            students.Add(new Student { FirstName = "Dan", LastName = "Sanders" });

            Students = students;
        }
    }
}
