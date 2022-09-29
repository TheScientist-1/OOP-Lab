// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

namespace WinFormsApp1
{

    public static class ProgramApp
    {


        public static string App_function(string? line)
        {
            //line = Console.ReadLine();
            int _;
            bool success = int.TryParse(line, out _);
            if (success)
            {
                return "Ви ввели число " + line;
            }
            else
            {
                return "Некоректний ввід";
            }
        }
    }
}
