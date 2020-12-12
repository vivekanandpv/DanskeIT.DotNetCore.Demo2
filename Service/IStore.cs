using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanskeIT.DotNetCore.Demo2.Service
{
    public interface IStore
    {
        public string GetInfo();
    }

    public class Store : IStore
    {
        private readonly IBook _book;

        public Store(IBook book)
        {
            Console.WriteLine("Creating store...");
            _book = book;
        }
        public string GetInfo()
        {
            return $"Store: {this._book.GetTitle()}";
        }
    }
}
