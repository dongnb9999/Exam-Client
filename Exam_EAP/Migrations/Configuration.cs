namespace Exam_EAP.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Exam_EAP.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Exam_EAP.MyContext context)
        {
            MyContext db = new MyContext();
            db.Students.AddOrUpdate(new Student("A100", "Quoc", "Anh", "0386324252", "anhdqth1804005fpt@gmail.com"));

            db.SaveChanges();
        }
    }
}
