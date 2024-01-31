// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");


using Hello;
using System;
namespace Helo // Note: actual namespace depends on the project name.
{
    class Program
    {
        //static void Greet()
        //{
        //    Console.WriteLine("Greeting");
        //}

        //static void Greet(string name) {
        //    //Console.WriteLine(name + " Good Morining");
        //}

        //static float Greet(int a, int b, int c) {
        //    float sum=a+b+c;
        //    return sum / 3;
        //}

        //static float Greet(int a, int b) 
        //{
        //    return a + b / 2;
        //}
        //default parameter
        //static void MyMethod(string country = "Norway")
        //{
        //    Console.WriteLine(country);
        //}

        static void Main(string[] args)
        {
            


            // Console.WriteLine("Variable");
            // var a = 10; //Integer Variable
            //Console.WriteLine(a);

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello SOurab");
            //Console.Write("Hi ! congrats");
            //Console.WriteLine(" Champ " + a);
            // Console.ReadLine();

            /* 
                DataTypes in C# :
            
                Integer - int a; -->  4 bytes
                Floating point number - float this; --> 4 bytes
                long - long a; --> 8 bytes
                Double - double a; -->  8bytes
                Character - char a= 'A'; --> 2 bytes
                Boolean - bool isGreat= true; --> 1 bit
                String - String inp= "Souab'; -->2 bytes perr character


            */

            // data type example
            //int b = 34;
            //float c = 28.8F;
            //double d = 25.9D;
            //bool isGreat=true;
            //char ch = 'k';
            //Console.ReadLine(); 
            //string s = "this is string";
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(b+c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(ch);
            //Console.WriteLine(s);

            // Type Casting
            // two type of type cating
            //1. Implicit casting

            //char to int to long to float to double

            //2. Explicit Casting


            //int aa =(int) 3.5;
            // Console.WriteLine(aa);
            //Implicit casting
            //int x = 3;
            //double y = x;
            // Console.WriteLine(y);
            //int zz = 'y';
            //int z =(int) y; // explicit type casting
            //double dd = 25.5;
            //int i =(int) dd; //explicit casting
            //Console.WriteLine(i);




            //Console.WriteLine(z);
            //Console.WriteLine(zz);//print ascii value

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("hey Hello " + name);


            //Console.WriteLine("How Many cadies do you want");
            //string can=Console.ReadLine();
            //Console.WriteLine(name+" will get 4 more candies so your total candies is " + (Convert.ToInt32 (can) + 4));
            // in above to convert string into int to add the number we have to usen Convert.ToInt32 in bracket likt this (Convert.ToInt32 (variable) + any number you want to add)

            //Operator  in C#
            /*
            1. Arithmetic Operator
            2. Assignment Operator
            3. Logical Operator
            4. Comparison Opearator
            */
            //int a = 4;
            //int b = 2;
            //Console.WriteLine(" The vale of  a + b is : "  + (a + b));
            //// we have to write in bracket (a+b) or else it do string concantenation
            //Console.WriteLine(" The vale of  a - b is : " + (a - b));
            //Console.WriteLine(" The vale of  a * b is : " + (a * b));

            //Console.WriteLine(" The vale of  a / b is : " + (a / b));

            // Assigment Operator 


            //int a = 4;
            //int b = a;
            //b += a; //b=b+a doing here
            //b -= a; // b=b-a
            // b *= a; //b=b*a
            //b /= a;  // b=b/a

            //b %= a;

            //b^=b;

            //Console.WriteLine(b);


            // Logical Operator

            //Console.WriteLine(true && false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && false);



            //Console.WriteLine(true || false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(true || false);


            // Console.WriteLine(!true);

            //Console.WriteLine(!false);

            //Comparison operator

            //int z = 5;
            //int y = 4;
            //Console.WriteLine(z>y);
            //Console.WriteLine(z < y);
            //Console.WriteLine(z <= y);
            //Console.WriteLine(z >= y);
            //Console.WriteLine(z != y);
            //Console.WriteLine(z == y);

            //int a = Math.Max(34, 325);
            //int b = Math.Min(34, 325);
            //double c = Math.Sqrt(36);
            //double d=Math.Abs(-4.7);
            //double e = Math.Round(63.2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);

            //string hello = "Hello World this is sou";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());

            //Console.WriteLine(hello+ " you are nice");

            //Console.WriteLine(string.Concat(hello, " you are nice"));


            //string name=Console.ReadLine();
            //string candies = Console.ReadLine();
            // Console.WriteLine( $" Your name is {name}. you will get {candies} candies ");

            //string hello = "Hello World this is sou";
            //Console.WriteLine(hello[0]);
            // Console.WriteLine(hello.IndexOf("sou"));
            //Console.WriteLine(hello.Substring(6));
            //Console.WriteLine(hello);

            //string hello = "Hello World this is \'Sourab\'";
            //Console.WriteLine(hello);   

            //string hello = "Hello World this is \n Sourab";
            //Console.WriteLine(hello);

            //string hello = "Hello World this is  \\ Sourab";
            //Console.WriteLine(hello);

            //string hello = "Hello World this is \"Sourab";
            //Console.WriteLine(hello);


            //string hello = "Hello World this is \t Sourab";
            //Console.WriteLine(hello);

            //string hello = "Hello World this is \b Sourab";
            //Console.WriteLine(hello);


            //int age = 16;
            //if( age > 18)
            //{
            //    Console.WriteLine("can drive");
            //}
            //else
            //{
            //    Console.WriteLine("cant drive");
            //}

            //below taking input from user 


            //Console.WriteLine("Enter Your Age");
            //string agestr=Console.ReadLine();
            //int age=Convert.ToInt32(agestr);    
            //if (age > 18)
            //{
            //    Console.WriteLine("can drive");
            //}else if(age<18 ){
            //    Console.WriteLine(" underage");
            //}
            //else
            //{
            //    Console.WriteLine("cant drive");
            //}

            //Switch Case

            //int age = 78;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("please wait an year");
            //       break;
            //    case 20:
            //        Console.WriteLine("you are 20");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}


            //Loops in C#



            //int i = 0;
            //while (i<5)
            //{
            //    Console.WriteLine(i+1);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //} while (i>  5);


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i <=10; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine("Outer : "+i);
            //}
            //for(int j = 1; j <= 3; j++)
            //{
            //    Console.WriteLine("inner : " + j);
            //}



            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //        break; //not utilized

            //    }
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {

            //        break;

            //    }
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while(i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i==4)
            //    {
            //        break;
            //    }
            //}

            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}



            // methods in C#


            //Greet("Sourab");
            //Greet("bittu");
            //Greet("Rohan");
            //Greet();
            // Console.WriteLine(Greet(3, 2, 3));
            //Console.WriteLine(Greet(2, 11));
            //MyMethod("India");
            //MyMethod("Norway");


            // oops concept in C#

            //classes and objects


            Player p = new Player();
            //Console.WriteLine(p.health);

            p.getHealth();
            Console.WriteLine(p.health);

            //p.getHealth(5);
            //Console.WriteLine(p.health);




        }
    }
}