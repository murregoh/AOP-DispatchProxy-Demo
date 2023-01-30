using System;

namespace DispatchProxyDemo.Services.Implementations
{
    public class TeacherService : ITeacherService
    {
        public void AddStudentGrade(string description, int grade)
            => Console.WriteLine($"Adding Student Grade. Description {description} - Grade {grade}");
    }

}
