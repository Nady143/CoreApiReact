using Core.ApplicationLayers.Interfaces;
using Core.ApplicationLayers.ViewModel;
using Core.DomainLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ApplicationLayers.Services
{
    public class CourseService : ICourseServices
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }

    }
}
