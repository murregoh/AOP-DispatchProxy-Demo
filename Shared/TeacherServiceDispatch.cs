using System;
using System.Reflection;

namespace DispatchProxyDemo.Shared
{
    public class TeacherServiceDispatch<T> : DispatchProxy
    {

        public T Target { get; set; }

        public static T Create<T>(T target) where T : class
        {
            var proxy = Create<T, TeacherServiceDispatch<T>>()
                as TeacherServiceDispatch<T>;

            proxy.Target = target;

            return proxy as T;
        }

        protected override object Invoke(
            MethodInfo targetMethod,
            object[] args)
        {
            Console.WriteLine("Teacher Service From TeacherServiceDispatch");
            return targetMethod.Invoke(Target, args);
        }
    }
}