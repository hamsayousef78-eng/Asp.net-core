namespace WebApplication1.Models.Services
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetById(int id);
        public void AddStudent(Student student);
        public void UpdateStudent(Student student);
        public void DeleteStudent(int id);
    }
}
