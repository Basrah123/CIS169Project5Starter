
using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;


public class SeedData
{
    public static void Initializer(IServiceProvider serviceProvider)
    {
        using (var context = new CourseCatalogContext(serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Courses == null)
            {
                throw new ArgumentNullException("Null Ccontext");
            }

            if (context.Courses.Any())
            {
                return;
            }
            
            context.Courses.AddRange(
            new Course()
            {
                CourseName = "Math",
                CourseDescription = "real-world utilization of complex mathematical formulas",
                RoomNumber = 123,
                StartTime = 12:00,
                EndTime = 12:00
            },
            new Course()
            {
                CourseName = "Science",
                CourseDescription = "utilization of physics, understanding of elements",
                RoomNumber = 455,
                StartTime = 10:00:15,
                EndTime = 12:00
            },
            new Course()
            {
                CourseName = "English",
                CourseDescription = "understanding grammar rules",
                RoomNumber = 669,
                StartTime = 12:00,
                EndTime = 12:00
            },
            new Course()
            {
                CourseName = "History",
                CourseDescription = "learning the eras and periods of both American and world history",
                RoomNumber = 909,
                StartTime = DateTime.("dd/MM/yy"),
                EndTime = 12:00
            },
            new Course()
            {
                CourseName = "Literature",
                CourseDescription = "reading notable literature pieces and understanding them",
                RoomNumber = 556,
                StartTime = 12:00,
                EndTime = 12:00
            }
        }
    }
}