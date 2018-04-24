namespace Exam
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityContext : DbContext
    {
        // Контекст настроен для использования строки подключения "UniversityContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Exam.UniversityContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "UniversityContext" 
        // в файле конфигурации приложения.
        public UniversityContext()
            : base("name=UniversityContext")
        {
           Database.SetInitializer(new UniversityInstaller());
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
    public class UniversityInstaller : DropCreateDatabaseAlways<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Nurkaiyr", Course = "1", });
            students.Add(new Student() { Id = 2, Name = "Vasya", Course = "2" });
            context.Students.AddRange(students);

            List<Group> groups = new List<Group>();
            groups.Add(new Group() { Id = 1, Course = 1 });
            groups.Add(new Group() { Id = 2, Course = 2 });
            context.Groups.AddRange(groups);

            List<Teachers> teachers = new List<Teachers>();
            teachers.Add(new Teachers() { Id = 1, Name = "Gregorii Petrov", Experience = 2, Occupation = "Doctor", });
            teachers.Add(new Teachers() { Id = 2, Name = "Somebody Someone", Experience = 3, Occupation = "Default" });
            context.Teachers.AddRange(teachers);

            List<Subject> subjects = new List<Subject>();
            subjects.Add(new Subject() { Id = 1, Name = "C++" });
            subjects.Add(new Subject() { Id = 2, Name = "History" });
            context.Subjects.AddRange(subjects);

            base.Seed(context);
        }
    }
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}