using Core.ApplicationLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ApplicationLayer.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourse();
    }
}
