using Microsoft.EntityFrameworkCore;

namespace Internet_1.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasData(
            //   new User() { Id = 1, UserName = "Categori 1", Email = "esra@", Password = "123",  },
            //   new User() { Id = 2, UserName = "Categori 1", Email = "esra@", Password = "123",  }
            //   );
            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, Name = "Öğrenci1", StudentNumber="16513", DateTime="11.111", IsActive = true },
                new Student() { Id = 2, Name = "Öğrenci2", StudentNumber = "16513", DateTime = "11.111", IsActive = true },
                new Student() { Id = 3, Name = "Öğrenci3", StudentNumber = "16513", DateTime = "11.111", IsActive = !true }
                );

            modelBuilder.Entity<Homework>().HasData(
           new Homework() { Id = 1, Name = "Kalem", StudentNumber = 10, Description = "Kalem açıklama", LessonName="a", IsActive = true ,StudentId = 1 },
           new Homework() { Id = 2, Name = "Defter", StudentNumber = 15, Description = "Defter açıklama", LessonName = "a", IsActive = true, StudentId = 2 },
           new Homework() { Id = 3, Name = "Silgi", StudentNumber = 20, Description = "Silgi açıklama", LessonName = "a", IsActive = false, StudentId = 3},
           new Homework() { Id = 4, Name = "Kitap", StudentNumber = 30, Description = "Kitap açıklama", LessonName = "a",IsActive = false, StudentId = 2 },
           new Homework() { Id = 5, Name = "Boya", StudentNumber = 25, Description = "Boya açıklama", LessonName = "a",IsActive = false, StudentId = 1 }
           );
        }
        
    }
}
