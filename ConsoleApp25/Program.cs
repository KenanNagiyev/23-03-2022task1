using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee("Kenan", "Nagiyev",20 ,8,40);
            Student stud = new Student("Ibrahim","Huseynov",20,50,77);
            
           
        }
    }
    abstract class Person
    {

        public abstract void FulName();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
    class Employee : Person
    {

        public override void FulName()
        {
            Console.WriteLine(Name + Surname + Age);
        }
        //SalaryofHour-1 saata aldigi maas
        //WorkingHour-1 ayda islediyi saat
        public int CalculateSalary(int SalaryofHour, int WorkingHour)
        {
            if (SalaryofHour<=8 && Age>=18 && SalaryofHour * WorkingHour >= 250)
            {
                return SalaryofHour * WorkingHour;
            }
            return -1;

        }
        public int SalaryofHour; 
        public int WorkingHour;
        public Employee(string name, string surname, int age, int salary, int hour)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.SalaryofHour = salary;
            this.WorkingHour = hour;

            Console.WriteLine("Name: "+name + " " + "Surname: "+surname + " " + "Age: "+age + " " + "Salary of Month: "+CalculateSalary(SalaryofHour,WorkingHour));
        }
        
    }
    class Student:Person
    {
        public override void FulName()
        {
            Console.WriteLine(Name + Surname + Age);
        }
        //IQRank-IQ imtahaninin neticesi
        //LanguageRank-Dil imtahaninin neticesi
        public int ExamResult(int IQRank, int LanguageRank)
        {
            if (IQRank<=100 && LanguageRank<=100 && Age>=6 && Age<=20 && IQRank + LanguageRank >= 120)
            {
                return IQRank + LanguageRank;
            }
            return -1;
            

        }
        public int IQRank;
        public int LanguageRank;
        public Student(string name, string surname, int age,int Iqrank,int Languagerank)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.IQRank = Iqrank;
            this.LanguageRank = Languagerank;

            Console.WriteLine("Name: "+ name + " " + "Surname: "+surname + " " + "Age: "+age + " " + "ExamResult: "+ExamResult(IQRank,LanguageRank));
        }
    }
}
