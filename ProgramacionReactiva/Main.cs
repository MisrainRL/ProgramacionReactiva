
namespace ProgramacionReactiva

{
    public class MainExercise
    {
        static void Main(string[] args)
        {
            StudentRecords records = new StudentRecords();
            records.StudentAdded += (sender, student) =>
            {
                //.WriteLine($"{student.Name} was added, he is {student.Age} years old and his email is {student.Email}");
            };

            records.AddStudent("Juan", 20, "juan@mail.com");
            records.AddStudent("Maria", 18, "maria@mail.com");
            records.AddStudent("Carlos", 22, "carlos@mail.com");
            records.AddStudent("Miguel", 28, "m@mail.com");
            records.AddStudent("Ana", 18, "a@mail.com");
            records.AddStudent("JJ", 22, "jj@mail.com");
            records.ShowStudents();
            records.StudentDeleted += (sender, student) =>
            {
                Console.WriteLine($"{student.Name} fue eliminad@.");
            };



            records.DeleteStudent(new Student() { Name = "Maria", 
                                    Age = 18, Email = "maria@mail.com" });

            records.DeleteStudent(new Student()
            {
                Name = "Ana",
                Age = 18,
                Email = "a@mail.com"
            });
           // records.ShowStudents();
        }
    }
}
