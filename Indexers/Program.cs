using System;

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Michael";
            Console.WriteLine(cookie["name"]);
        }
    }
}
