using Core.DataLayer.Context;
using Core.DomainLayer.Interfaces;
using Core.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataLayer.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
