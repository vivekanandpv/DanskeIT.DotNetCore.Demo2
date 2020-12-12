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
        private readonly Guid _guid;

        public Store(IBook book)
        {
            this._guid = Guid.NewGuid();
            Console.WriteLine($"Creating store...{this._guid}");
            _book = book;
        }
        public string GetInfo()
        {
            return $"Store: {this._book.GetTitle()} / Guid: {this._guid}";
        }
    }
}
