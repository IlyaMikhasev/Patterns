using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Employer {
        private int age;
        private string name;
        public Employer(int _age, string _name) {
            age = _age;
            name = _name;        
        }
        public int Age {  get { return age; } set{
                if (Age > 0)
                    this.Age = age;
                else this.Age = 1;
            } }
        public string Name { get { return name; } }
        public virtual void PrintWorkTime() {
            Console.WriteLine($"Сотрудник {this.name} работает 5/7 8 часов в сутки");
        }
    }
    public class YoungEmploer : Employer {
        private int age;
        public YoungEmploer(int _age, string _name) : base(_age, _name) {
            age = _age;
        }
        public new int Age { get { return age; } set { age = value; } }
        public override void PrintWorkTime()
        {
            if (Age > 18)
            {
                base.PrintWorkTime();
            }
            else
            {
                Console.WriteLine($"Сотрудник {base.Name} работает 5/7 4 часa в сутки");
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employer worker = new Employer(54, "old");
            YoungEmploer yWorker = new YoungEmploer(14, "boy");
            worker.PrintWorkTime();
            yWorker.PrintWorkTime();
            yWorker.Age = 23;
            yWorker.PrintWorkTime();
            int[] _arr = { 1, 2, 2, 3, 4, 5, 6, 7, 9 };
            Console.WriteLine(_arr.Where(x => x % 2 == 0).Sum());
        }
    }
}
