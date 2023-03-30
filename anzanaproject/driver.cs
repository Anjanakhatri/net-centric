using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anzanaproject
{
    public class driver : person
    {
        public string driverLiscenseNo { get; set; }
        public new void  Desc()
        {
            Console.WriteLine("I am a driver");
            base.Desc();
        }
        public driver(string name, int noofeyes, int height, string color) : base(name, noofeyes, height, color) { }
    }
}
