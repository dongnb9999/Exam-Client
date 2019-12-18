using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam_EAP
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {
        }

        public DbSet<Student> Students { get; set; }

        public static MyContext Create()
        {
            return new MyContext();
        }
    }
}