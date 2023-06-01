using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Тёма", "Иванов", "Петрович", 20);
            client.Print();
        }

    }
    class Client
    {
        private string FirsName;
        private string LastName;
        private string Patronymic;
        private int Age;

        public string Firsname
        {
            get { return FirsName; }
            set { FirsName = value; }
        }
        public string Lastname
        { 
            get { return LastName; } 
            set { LastName = value; }
        }
        public string patronymic 
        { 
            get { return Patronymic; } 
            set { Patronymic = value; } 
        }
        private int age 
        { 
            get { return Age; } 
            set { Age = value; }
        }
        public Client(string FirstName,string LastName,string Patronymic,int Age)
        {
            this.FirsName = FirstName;
            this.LastName = LastName;
            this.Patronymic = Patronymic;
            this.Age = Age;
        }
        public void Print()
        {
            Console.WriteLine("Имя:" + FirsName);
            Console.WriteLine("Фамилия:" + LastName);
            Console.WriteLine("Отчество:" + Patronymic);
            Console.WriteLine("Возраст:" + Age);
        }
    }
}
