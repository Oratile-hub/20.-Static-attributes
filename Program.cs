using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Static_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Songs song1 = new Songs("Holiday", "Green Day", 115);
            Songs song2 = new Songs("Billy Jean", "MJ", 200);
            Console.WriteLine(song1.title);
            Console.WriteLine(Songs.songCount);

            //freeze console
            Console.ReadLine();
        }
    }
}
