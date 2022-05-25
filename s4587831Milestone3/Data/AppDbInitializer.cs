using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using s4587831Milestone3.Data.Static;
using s4587831Milestone3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Difficulty
                if (!context.Difficulties.Any())
                {
                    context.Difficulties.AddRange(new List<Difficulty>()
                    {
                        new Difficulty()
                        {
                            Name = "Easy",
                            Logo = "https://www.linkpicture.com/q/d1_7.png",
                            Description = "This indicates that this course has a difficulty of 'easy'."
                        },
                        new Difficulty()
                        {
                            Name = "Moderately Easy",
                            Logo = "https://www.linkpicture.com/q/d2_5.png",
                            Description = "This indicates that this course has a difficulty of 'moderately easy'."
                        },
                        new Difficulty()
                        {
                            Name = "Medium Difficulty",
                            Logo = "https://www.linkpicture.com/q/d3_2.png",
                            Description = "This indicates that this course has a difficulty of 'medium'."
                        },
                        new Difficulty()
                        {
                            Name = "Moderately hard",
                            Logo = "https://www.linkpicture.com/q/d4_3.png",
                            Description = "This indicates that this course has a difficulty of 'moderately difficult'."
                        },
                        new Difficulty()
                        {
                            Name = "Hard",
                            Logo = "https://www.linkpicture.com/q/d5.png",
                            Description = "This indicates that this course has a difficulty of 'very difficult'."
                        },
                    });
                    context.SaveChanges();
                }
                //Teachers
                if (!context.Teachers.Any())
                {
                    context.Teachers.AddRange(new List<Teacher>()
                    {
                        new Teacher()
                        {
                            FullName = "Teacher 1",
                            Bio = "This is the Bio of the first teacher",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T1.jpg"

                        },
                        new Teacher()
                        {
                            FullName = "Teacher 2",
                            Bio = "This is the Bio of the second teacher.",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T2.jpg"
                        },
                        new Teacher()
                        {
                            FullName = "Teacher 3",
                            Bio = "This is the Bio of the third teacher",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T3.webp"
                        },
                        new Teacher()
                        {
                            FullName = "Teacher 4",
                            Bio = "This is the Bio of the fourth teacher.",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T4.jpg"
                        },
                        new Teacher()
                        {
                            FullName = "Teacher 5",
                            Bio = "This is the Bio of the fifth teacher.",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Convenors
                if (!context.Convenors.Any())
                {
                    context.Convenors.AddRange(new List<Convenor>()
                    {
                        new Convenor()
                        {
                            FullName = "Convenor 1",
                            Bio = "This is the Bio of the first convenor",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T2.jpg"

                        },
                        new Convenor()
                        {
                            FullName = "Convenor 2",
                            Bio = "This is the Bio of the second convenor",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T1.jpg"
                        },
                        new Convenor()
                        {
                            FullName = "Convenor 3",
                            Bio = "This is the Bio of the third convenor",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T5.jpeg"
                        },
                        new Convenor()
                        {
                            FullName = "Convenor 4",
                            Bio = "This is the Bio of the fourth convenor",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T4.jpg"
                        },
                        new Convenor()
                        {
                            FullName = "Convenor 5",
                            Bio = "This is the Bio of the fifth convenor",
                            ProfilePictureURL = "https://www.linkpicture.com/q/T3.webp"
                        }
                    });
                    context.SaveChanges();
                }
                //Courses
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            Name = "Introduction to International Finances",
                            Description = "This is the Introduction to International Finances description",
                            Price = 9.50,
                            ImageURL = "https://www.linkpicture.com/q/C1.png",
                            StartDate = DateTime.Now.AddDays(-100),
                            EndDate = DateTime.Now.AddDays(-70),
                            DifficultyId = 1,
                            ConvenorId = 5,
                            CourseSubject = CourseSubject.Finance
                        },
                        new Course()
                        {
                            Name = "Media Communications",
                            Description = "This is the Media Communications description",
                            Price = 19.50,
                            ImageURL = "https://www.linkpicture.com/q/c2_1.jpg",
                            StartDate = DateTime.Now.AddDays(-3),
                            EndDate = DateTime.Now.AddDays(27),
                            DifficultyId = 2,
                            ConvenorId = 4,
                            CourseSubject = CourseSubject.Communications
                        },
                        new Course()
                        {
                            Name = "Chemical Reaction Engineering",
                            Description = "This is the Chemical Reaction Engineering description",
                            Price = 10.50,
                            ImageURL = "https://www.linkpicture.com/q/c3_3.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(30),
                            DifficultyId = 5,
                            ConvenorId = 1,
                            CourseSubject = CourseSubject.Engineering
                        },
                        new Course()
                        {
                            Name = "Systems Biology",
                            Description = "This is the Systems Biology description",
                            Price = 9.50,
                            ImageURL = "https://www.linkpicture.com/q/c4_3.png",
                            StartDate = DateTime.Now.AddDays(100),
                            EndDate = DateTime.Now.AddDays(130),
                            DifficultyId = 4,
                            ConvenorId = 1,
                            CourseSubject = CourseSubject.Biology
                        },
                        new Course()
                        {
                            Name = "Financial Management",
                            Description = "This is the Financial Management description",
                            Price = 5.50,
                            ImageURL = "https://www.linkpicture.com/q/c5.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(20),
                            DifficultyId = 3,
                            ConvenorId = 5,
                            CourseSubject = CourseSubject.Finance
                        },
                        new Course()
                        {
                            Name = "Introduction to Digital Communications",
                            Description = "This is the Introduction to Digital Communications description",
                            Price = 9.50,
                            ImageURL = "https://www.linkpicture.com/q/c6_1.png",
                            StartDate = DateTime.Now.AddDays(-12),
                            EndDate = DateTime.Now.AddDays(18),
                            DifficultyId = 1,
                            ConvenorId = 5,
                            CourseSubject = CourseSubject.Communications
                        },
                    });
                    context.SaveChanges();
                }
                //Teachers & Courses
                if (!context.Teachers_Courses.Any())
                {
                    context.Teachers_Courses.AddRange(new List<Teacher_Course>()
                    {
                        new Teacher_Course()
                        {
                            TeacherId = 5,
                            CourseId = 1
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 3,
                            CourseId = 1
                        },
                         new Teacher_Course()
                        {
                            TeacherId = 2,
                            CourseId = 2
                        },
                         new Teacher_Course()
                        {
                            TeacherId = 1,
                            CourseId = 2
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 4,
                            CourseId = 3
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 3,
                            CourseId = 3
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 1,
                            CourseId = 3
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 2,
                            CourseId = 4
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 5,
                            CourseId = 4
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 4,
                            CourseId = 4
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 2,
                            CourseId = 5
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 1,
                            CourseId = 5
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 3,
                            CourseId = 5
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 5,
                            CourseId = 5
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 1,
                            CourseId = 6
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 4,
                            CourseId = 6
                        },
                        new Teacher_Course()
                        {
                            TeacherId = 2,
                            CourseId = 6
                        },
                    });
                    context.SaveChanges();
                }


            }
        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@learningzone.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@learningzone.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}