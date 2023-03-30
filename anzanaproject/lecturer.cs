using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anzanaproject
{
    public class lecturer:person
    {
        public string degree { get; set; }
        public new void Desc() {
            Console.WriteLine("I am a lecture");
            base.Desc();
        }
    public lecturer(string name,int noofeyes,int height,string color):base(name,noofeyes,height,color) { 
        }
    }
}
