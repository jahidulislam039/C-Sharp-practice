using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("Enter First Number: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);

Console.Write("Enter Second Number: ");
string c = Console.ReadLine();
int d = Convert.ToInt32(c);

if (b>d)
{
Console.WriteLine("First Number is Larger");

}
else
{
Console.WriteLine("Second Number Is Larger");
}


Console.ReadLine();
}
Console.Write("Enter Array Size: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);

string d="0";
int i = Convert.ToInt32(d);


string[] z = new string[b];
int[] c = new int[b];


Console.WriteLine("Enter Array Ellements: ");
for (i = 0; i<b; i++)
{

z[i] = Console.ReadLine();
}

Console.WriteLine("The Array Elements are: ");
for (i = 0; i < b; i++)
{

Console.Write(c[i]+" ");
}
Console.ReadLine();


//Linear Search

for ( i = 0; i < b; i++)
{

c[i] = Convert.ToInt32(z[i]);
}

Console.WriteLine("Enter The Number to be searched");
string e = Console.ReadLine();
int f = Convert.ToInt32(e);

for (i = 0; i<b; i++)
{
if (c[i]==f)
{
Console.WriteLine("Number at index:" + b);
}

}
Console.ReadLine();*/

            // jagged Array and for each loop
            int[][,] jagged = new int[][,]
            {
                new int [,]{ { 1, 2 }, { 3, 4}, { 5, 6 } },
                new int [,]{ { 6, 8}, { 9,10} },
                new int [,]{ { 11, 12, 13}, { 15, 16, 17} }
            };
            string y = Console.ReadLine();
            int z = Convert.ToInt32(y);
            jagged[1][0, 0] = z;

            foreach (int[,] a in jagged)
            {
                foreach (int b in a)
                    Console.Write(b);
            }
            Console.ReadLine();


        }

    }
}
