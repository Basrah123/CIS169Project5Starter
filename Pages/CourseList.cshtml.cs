using CourseCatalog.Models;
using CourseCatalog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CourseCatalog.Pages;

public class CourseListModel : PageModel
{
    private readonly CourseService _service;
    public IList<Course> CourseList{get; set; } = default;
    
    [BindProperty]
    public Course NewCourse {get; set;} = default;
    
    public CourseListModel(CourseService service)
    {
        _service = service;
    }
    public void OnGet()
    {
        CourseList = _service.GetCourses();
    }
    
    public IActionResult OnPost()
    {
        if(ModelState.IsValid || NewCourse == null)
        {
            return Page();
        }
        _service.AddCourse(NewCourse);
        return RedirectToAction("Get");
    }

    public IActionResult OnPostDelete(int id)
    {
        _service.DeleteCourse(id);
        return RedirectToAction("Get");
    }
}