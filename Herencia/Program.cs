using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Arturo", 30, "Cardiologo");
            Console.WriteLine(doctor.GetInfo());
            Console.WriteLine(doctor.GetDate());
            Dev dev = new Dev("Yael", 21, "Python");
            Console.WriteLine(dev.GetInfo());
            Console.WriteLine(dev.GetDate());
        }
    }

    class People
    {
        private string _name;
        private int _age;

        public People(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetInfo()
        {
            return _name + " " + _age;
        }
    }

    class Doctor : People
    {
        private string _speciality;

        public Doctor(string name, int age, string speciality) : base(name, age)
        {
            _speciality = speciality;
        }

        public string GetDate()
        {
            return GetInfo() + " " + _speciality;
        }
    }

    class Dev : People
    {
        private string _language;

        public Dev(string name, int age, string language) : base(name, age)
        {
            _language = language;
        }

        public string GetDate()
        {
            return GetInfo() + " " + _language;
        }
    }
}
