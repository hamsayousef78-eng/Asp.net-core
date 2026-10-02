using System.Xml.Linq;

namespace WebApplication1.Models.Services
{
    public class StudentService:IStudentService
    {
        #region Fields
        public List<Student> Students { set; get; }
        #endregion

        #region Constructors
        public StudentService()
        {
            Students = new List<Student>
            {
                new Student(){ Id = 1, name = "hamsa",email="hamsa@gmail.com" } ,
                new Student(){ Id = 2, name = "nada",email="nada@gmail.com" },
                new Student(){ Id = 3, name = "mena",email="mena@gmail.com" },
                new Student(){ Id = 4, name = "reem" ,email="reem@gmail.com"},
                new Student(){ Id = 5, name = "rana" ,email="rana@gmail.com"}
            };
        }
        #endregion

        #region Function Implementation

        //Add Student
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        //Get Student By Id
        public Student GetById(int id)
        {
            var st = Students.FirstOrDefault(s => s.Id == id);
            return st;//هيرجعلي الطالب لي ليه ال id ده
        }
        //Delete Student
        public void DeleteStudent(int id)
        {
            var st = GetById(id);
            Students.Remove(st);
        }
        //Get All Students
        public List<Student> GetStudents()
        {
            return Students;
        }
        //Update Student
        public void UpdateStudent(Student student)
        {
            var st = Students.FirstOrDefault(s => s.Id == student.Id);
            st.name = student.name;
            st.email = student.email;
        }
        #endregion
    }
}
