using DispatchProxyDemo.Services;
using DispatchProxyDemo.Services.Implementations;
using DispatchProxyDemo.Shared;

namespace DispatchProxyDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacherService teacherService = new TeacherService();

            teacherService = TeacherServiceDispatch<ITeacherService>
                .Create(teacherService);

            teacherService.AddStudentGrade("Math", 5);
        }
    }
}