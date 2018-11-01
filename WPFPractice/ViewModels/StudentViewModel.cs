using WPFPractice.Models;
using System.Collections.ObjectModel;

namespace WPFPractice.ViewModels
{
    class StudentViewModel
    {
        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public MyICommand DeleteCommand { get; set; }

        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        public void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        public bool CanDelete()
        {
            return SelectedStudent != null;
        }

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
