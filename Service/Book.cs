using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanskeIT.DotNetCore.Demo2.Service
{
    public class Book
    {
        private readonly string _title = "Programming C#";
        public Book()
        {
            Console.WriteLine("Creating book...");
        }
        public string GetTitle() => this._title;
    }
}
