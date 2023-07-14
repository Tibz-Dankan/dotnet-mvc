using System.Collections.Generic;
using System.Linq;

public class StudentRepository
{
    private readonly StudentDbContext _dbContext;

    public StudentRepository(StudentDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Student> GetAllStudents()
    {
        return _dbContext.Students.ToList();
    }

    public Student GetStudentById(int id)
    {
        return _dbContext.Students.FirstOrDefault(s => s.Id == id);
    }

    public void AddStudent(Student student)
    {
        _dbContext.Students.Add(student);
        _dbContext.SaveChanges();
    }

    public void UpdateStudent(Student student)
    {
        _dbContext.Students.Update(student);
        _dbContext.SaveChanges();
    }

    public void DeleteStudent(Student student)
    {
        _dbContext.Students.Remove(student);
        _dbContext.SaveChanges();
    }
}
