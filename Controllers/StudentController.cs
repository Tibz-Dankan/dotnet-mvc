using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentsController(StudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public ActionResult<List<Student>> GetAllStudents()
    {
        var students = _studentService.GetAllStudents();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public ActionResult<Student> GetStudentById(int id)
    {
        var student = _studentService.GetStudentById(id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(student);
    }

    [HttpPost]
    public ActionResult<Student> AddStudent(Student student)
    {
        _studentService.AddStudent(student);
        return Ok(student);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateStudent(int id, Student student)
    {
        if (id != student.Id)
        {
            return BadRequest();
        }
        _studentService.UpdateStudent(student);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id)
    {
        _studentService.DeleteStudent(id);
        return NoContent();
    }
}
