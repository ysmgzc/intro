using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business
{
    internal class CourseManager
    {
        Course[] courses=new Course[2];
        //constructor
        //veritababnından veri çekmediiğimiz için burada yapay veri oluşturduk
        public  CourseManager()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "e.Demirog";
            course1.Description = "message";
            course1.Price = 12.5;

            Course course2 = new Course();
            course2.Id = 1;
            course2.Name = "YG";
            course2.Description = "yy";
            course2.Price = 12.5;

            courses[0] = course1;
            courses[1] = course2;
        }


        public Course[] GetAll()
        {
            //NŞA'da vertitabanından çekilir
            return courses;
        }
    }
}
