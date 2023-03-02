namespace ProgramacionReactiva
{ 
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    public class StudentRecords
    {
        public event EventHandler<Student> StudentAdded;
        public event EventHandler<Student> StudentDeleted;

        private List<Student> students = new List<Student>();

        public void AddStudent(string name, int age, string email)
        {
            Student student = new Student() { Name = name, Age = age, Email = email };
            students.Add(student);
            StudentAdded?.Invoke(this, student);
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
            StudentDeleted?.Invoke(this, student);
        }

        public void ShowStudents()
        {
            students.ForEach((student) =>
            {
                Console.WriteLine($"Se agregó {student.Name}, " +
                    $"que tiene {student.Age} años " +
                    $"y su correo electrónico es {student.Email}");

            });
        }
    }
}