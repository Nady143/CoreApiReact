using Core.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DomainLayer.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
