using CourseCatalog.Data;
using CourseCatalog.Models;

namespace CourseCatalog.Services;

public class CourseService
{
    private readonly CourseCatalogContext _context = default!;

    public CourseService(CourseCatalogContext context) 
    {
        _context = context;
    }
        
    public IList<Course> GetCourses()
    {
        if(_context.Courses != null)
        {
            return _context.Courses.ToList();
        }
        return new List<Course>();
    }

    public void AddCourse(Course course)
    {
        if (_context.Courses != null)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }

    public void DeleteCourse(int id)
    {
        if (_context.Courses != null)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }            
    } 
}