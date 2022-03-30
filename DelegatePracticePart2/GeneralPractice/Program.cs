using GeneralPractice.Models;
using System;
using Utils.Enums;

namespace GeneralPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(typeof(User));
            byte role;
            bool isNum;
            do
            {
                Console.WriteLine("Role (1. Admin, 2.Member):");
                string roleStr = Console.ReadLine();
                isNum = byte.TryParse(roleStr, out role);
            } while (!isNum || !Enum.IsDefined(typeof(Role), role));
        }
    }
}
