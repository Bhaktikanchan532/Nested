using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  Alphabet");

            //Console.WriteLine("a");
            //Console.WriteLine("e");
            //Console.WriteLine("i");
            //Console.WriteLine("o");
            //Console.WriteLine("u");
            //Console.WriteLine("A");
            //Console.WriteLine("E");
            //Console.WriteLine("I");
            //Console.WriteLine("O");
            //Console.WriteLine("U");
            char ch; 
                ch= Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':

                    Console.WriteLine("vowel");
                    break;

                case 'e':

                    Console.WriteLine("vowel");
                    break;

                case 'i':

                    Console.WriteLine("vowel");
                    break;

                case 'o':

                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;

                case 'A':

                    Console.WriteLine("vowel");
                    break;
                case 'E':

                    Console.WriteLine("vowel");
                    break;

                case 'I':

                    Console.WriteLine("vowel");
                    break;

                case 'O':

                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("consonant");
                    break;
            }
        }
    }
}