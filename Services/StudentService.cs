using System.Collections.Generic;

public class StudentService
{
    private readonly StudentRepository _studentRepository;

    public StudentService(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public List<Student> GetAllStudents()
    {
        return _studentRepository.GetAllStudents();
    }

    public Student GetStudentById(int id)
    {
        return _studentRepository.GetStudentById(id);
    }

    public void AddStudent(Student student)
    {
        Console.WriteLine("student");
        Console.WriteLine(student);
        _studentRepository.AddStudent(student);
    }

    public void UpdateStudent(Student student)
    {
        _studentRepository.UpdateStudent(student);
    }

    public void DeleteStudent(int id)
    {
        var student = _studentRepository.GetStudentById(id);
        if (student != null)
        {
            _studentRepository.DeleteStudent(student);
        }
    }
}
