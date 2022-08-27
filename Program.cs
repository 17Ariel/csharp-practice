using System;
using System.Linq;
namespace basics
{

    class Program
    {

        static void Main(string[] args)
        {

            // Console.WriteLine("hellow world");


            // accept user input and print
            // string name;

            // Console.Write("Enter your name: ");
            // name = Console.ReadLine();

            // string yourName = name;

            // Console.WriteLine("Your name is: " + yourName);

            // variables

            // int age = 23;
            // double change = 34.900;
            // float change2 = 90.8F;
            // long cash = 190000000;
            // bool isActive = true;
            // string fullname = "John Doe";
            // char letter = 'e';

            // Console.WriteLine("Im " + fullname + "My salary is " + cash + ", my favorite letter is " + letter + "My age is " + age + "my change in pocket is" + change2 + "and in the bag is" + change + "and im currently" + isActive + "in facebook");

            //operators

            // int numb1 = 10, numb2 = 9;

            // Console.WriteLine(numb1 + numb2);
            // Console.WriteLine(numb1 - numb2);
            // Console.WriteLine(numb1 * numb2);
            // Console.WriteLine(numb1 / numb2);
            // Console.WriteLine(numb1 % numb2);


            //math

            // int numb1 = 6;
            // int numb2 = 4;
            // double numb3 = 8.7;

            // Console.WriteLine(Math.Max(numb1, numb2));
            // Console.WriteLine(Math.Min(numb1, numb2));
            // Console.WriteLine(Math.Sqrt(numb1));
            // Console.WriteLine(Math.Abs(numb2));
            // Console.WriteLine(Math.Round(numb3));

            //Strings

            // string word = "Hello CSharp";
            // string fword = "Hello";
            // string sword = "Their";
            // string concat = string.Concat(fword, sword);
            // string sentence = "Hello \"Boy\" from Walak";
            // string sentence2 = "It\'s me";
            // string sentence3 = "Hello \\ Wawa";

            // Console.WriteLine(word.Length);
            // Console.WriteLine(word.ToLower());
            // Console.WriteLine(word.ToUpper());
            // Console.WriteLine(fword + sword);
            // Console.WriteLine(concat);
            // Console.WriteLine($"{fword} {sword}");
            // Console.WriteLine(word[2]);
            // Console.WriteLine(word.IndexOf("e"));
            // Console.WriteLine(sentence);
            // Console.WriteLine(sentence2);
            // Console.WriteLine(sentence3);

            //condition

            // string user = "Jdoes";

            // if (user == "Jdoe")
            // {
            //     Console.WriteLine(true);
            // }
            // else if (user != "Jdoe")
            // {
            //     Console.WriteLine(false);

            // }
            // else
            // {
            //     Console.WriteLine(user);
            // }

            // Console.WriteLine(user == "Jdoe" ? true : false);

            //switch case

            // int numb = 18;

            // switch (numb)
            // {
            //     case 10:
            //         Console.WriteLine("Equal");
            //         break;
            //     case 8:
            //         Console.WriteLine("8");
            //         break;
            //     default:
            //         Console.WriteLine("Invalid");
            //         break;
            // }

            //loops

            // int index = 0;

            // while (index < 10)
            // {
            //     Console.WriteLine(index);
            //     index++;
            // }

            // for (int i = 10; i > 0; i--)
            // {
            //     Console.WriteLine(i);

            // }

            // int y = 0;

            // do
            // {
            //     Console.WriteLine(y);
            //     y++;
            // } while (y < 11);

            // for (int x = 0; x < 10; x++)
            // {
            //     if (x == 5)
            //     {
            //         break;
            //     }
            //     Console.WriteLine(x);

            // }

            // for (int y = 0; y < 10; y++)
            // {
            //     if (y == 4)
            //     {
            //         continue;
            //     }
            //     Console.WriteLine(y);
            // }

            string[] names = { "Howard", "Michael", "Tim" };

            // for (int index = 0; index < names.Length; index++)
            // {
            //     Console.WriteLine(names[index]);
            // }

            foreach (string name in names)
            {
                // Console.WriteLine(name);
                Array.Sort(names);
                Console.WriteLine(name);


            }

            int[] numbers = { 4, 9, 2 };

            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());














        }
    }
}