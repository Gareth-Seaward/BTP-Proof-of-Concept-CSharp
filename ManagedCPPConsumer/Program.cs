using System;

namespace ManagedCPPConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cppManager = new CallbackManager();
            cppManager.OnEnum += HandleCpp;

            var student = new StudentWrapper("Gareth", 45);

            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Student GPA: {student.Gpa}");

            //new FormHandler().ShowMessageBox("From C#");
             
            cppManager.RaiseEvent(1);

            Console.ReadLine();
        }

        private static bool HandleCpp(int h)
        {
            Console.WriteLine($"Cot handle from C++/CLI: {h}");
            return true;
        }
    }
}
