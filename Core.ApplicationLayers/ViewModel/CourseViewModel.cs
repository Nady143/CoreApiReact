using Core.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ApplicationLayers.ViewModel
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
