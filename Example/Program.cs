using ConsoleForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ConsoleForms v1.0.0-alpha Demo";
            FormWindow NewForm = new FormWindow();
            NewForm.Show();
            Console.ReadKey();
        }
    }
}
