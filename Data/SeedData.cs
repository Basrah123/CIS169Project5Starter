
using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;


public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CourseCatalogContext(serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Courses == null)
            {
                throw new ArgumentNullException("Null Ccntext");
            }

            if (context.Courses.Any())
            {
                return;
            }
            string startTime1 = "8:00";
            TimeOnly start1 = TimeOnly.Parse(startTime1);
            
            string endTime1 = "9:00";
            TimeOnly end1 = TimeOnly.Parse(endTime1);
            
            string startTime2 = "9:30";
            TimeOnly start2 = TimeOnly.Parse(startTime2);
            
            string endTime2 = "10:30";
            TimeOnly end2 = TimeOnly.Parse(endTime2);
            
            string startTime3 = "11:00";
            TimeOnly start3 = TimeOnly.Parse(startTime3);
            
            string endTime3 = "12:00";
            TimeOnly end3 = TimeOnly.Parse(endTime3);
            
            string startTime4 = "12:30";
            TimeOnly start4 = TimeOnly.Parse(startTime4);
            
            string endTime4 = "1:30";
            TimeOnly end4 = TimeOnly.Parse(endTime4);
            
            string startTime5 = "1:30";
            TimeOnly start5 = TimeOnly.Parse(startTime5);
            
            string endTime5 = "2:30";
            TimeOnly end5 = TimeOnly.Parse(endTime5);
            
            context.Courses.AddRange(
                new Course()
                {
                    CourseName = "Math",
                    CourseDescription = "real-world utilization of complex mathematical formulas",
                    RoomNumber = 123,
                    StartTime = start1,
                    EndTime = end1
                },
                new Course()
                {
                    CourseName = "Science",
                    CourseDescription = "utilization of physics, understanding of elements",
                    RoomNumber = 455,
                    StartTime = start2,
                    EndTime = end2
                },
                new Course()
                {
                    CourseName = "English",
                    CourseDescription = "understanding grammar rules",
                    RoomNumber = 669,
                    StartTime = start3,
                    EndTime = end3
                },
                new Course()
                {
                    CourseName = "History",
                    CourseDescription = "learning the eras and periods of both American and world history",
                    RoomNumber = 909,
                    StartTime = start4,
                    EndTime = end4
                },
                new Course()
                {
                    CourseName = "Literature",
                    CourseDescription = "reading notable literature pieces and understanding them",
                    RoomNumber = 556,
                    StartTime = start5,
                    EndTime = end5
                }
            );
            context.SaveChanges();
        }
    }
}