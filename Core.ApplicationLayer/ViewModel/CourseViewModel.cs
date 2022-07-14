using Core.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ApplicationLayer.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
