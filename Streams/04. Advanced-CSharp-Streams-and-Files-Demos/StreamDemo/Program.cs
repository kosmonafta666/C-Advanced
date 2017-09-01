using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fs = new FileStream("somefile.txt", FileMode.Create);
        }
    }
}
