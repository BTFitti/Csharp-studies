// int
// double
// char 
// string
// bool

// decimal
// float
// byte
// sbyte
// short
// ushort
// uint
// long
// ulong
using System;
using System.Globalization;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double salary, height;
            char gender;
            string name;
            age = 24;
            salary = 4000.9;
            height = 1.72;
            gender = 'M';
            name = "Robert";
            Console.WriteLine($"Name: {name} \nAge: {age} \nGender: {gender} \nHeight: {height} \nSalary: {salary}");
            /*
            ----------------------------------------------------------------------------------------------------------------
            */
            double totalEarnings;
            bool isWorking;
            isWorking = true;
            totalEarnings =(float)(salary  * 12) ;
            Console.WriteLine($"IsWorking: {isWorking} \nTotalEarnings: {totalEarnings.ToString("F0")}");
        }
    }
}
