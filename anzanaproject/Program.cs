using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anzanaproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("hello world!");
            
           Console.WriteLine("enter your favroite color");
            string favcolor= Console.ReadLine();
            switch (favcolor)
            {
                case "red":
                    Console.WriteLine("you are lovely");
                    break;
                case "blue":
                    Console.WriteLine("you are peaceful");
                    break;
                case "green":
                    Console.WriteLine("you love nature");
                    break;
            }
           for (int i=0;i<5;i++)
            {
                Console.WriteLine("your loop is in " + i + "state");
            }
            int counter = 100;
            while (counter >0)
            {
                Console.WriteLine("number is " + counter);
                counter /= 5;
            }*/
            //person anjana = new person("anjana",2,5,"black");
           /* anjana.name = "anjana";
            anjana.noofeyes = 2;
            anjana.height = 5;
            anjana.color = "black";
            anjana.launch();
            anjana.mycolor();*/
            //anjana.mydes();
           // person john=new person("john",2,6,"blue");
            /*john.name = "john";
            john.noofeyes = 2;
            john.height = 5;
            john.color = "blue";*/
           //john.mydes();
            driver Ram=new driver("Ram",2,6,"black");
            lecturer Umesh=new lecturer("Umesh",2,5,"white");
            Ram.Desc();
            Umesh.Desc();
            Umesh.Desc();
            Console.ReadKey();
        }
    }
}
