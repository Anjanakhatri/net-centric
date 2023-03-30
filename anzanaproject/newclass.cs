using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anzanaproject
{

    public  class person
    {
        public string name { get; set; }
        public int noofeyes { get; set; }
        public int height { get; set; }

        public string color { get; set; }
        public void launch()
        {
            Console.WriteLine("I usually have momo in lauch");
        }
        public void mycolor()
        {
            Console.WriteLine("my face color is " + color);

        }
        public void Desc()
        {
            Console.WriteLine("my name is " + name);
            Console.WriteLine("I have " + noofeyes + "eyes");
            Console.WriteLine("my facecolor is " + color);
            Console.WriteLine("I am " + height + "feet tall");
        }
        public person(string Name,int Noofeyes,int Height,string facecolor)
        {
            name = Name;
            noofeyes = Noofeyes;
            height = Height;
            color = facecolor;
        }
        public person() { }
        
        // ~person() { }
    }
 


}
