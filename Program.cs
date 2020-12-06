using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaysofArrangingMultipleDimensionMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
           // GeneratedArray();
            GeneratedArray2();
        }

        public static void GeneratedArray()
        {

           
            try
            {

                int[,,,] myArray = new int[3, 4, 2, 3]
                {
                    {{{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }}},

                    {{{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }}},

                    {{{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }},
                    {{23,45,0 }, {23,45,0 }}}




                };

                Console.WriteLine("The matrix above has {0} number of rows", myArray.GetLength(0));
                Console.WriteLine("The matrix above has {0} number of columns", myArray.GetLength(1));
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }

            //OR


        }

        //OR BELOW IS AN ALTERNATIVE WAY TO PRESENT SAME SOLUTION ABOVE
        public static void GeneratedArray2()
        {

            
            try
            {

                int[,,,] myArray = new int[3, 4, 2, 3]
                {
                    {
                      {{23,45,0},
                      {23,45,0}},

                    {{23,45,0},
                     {23,45,0}},

                    {{23,45,0},
                    {23,45,0}},

                    {{23,45,0},
                    {23,45,0}}}, //1

                    {
                     {{23,45,0},
                     {23,45,0}},

                    {{23,45,0},
                    {23,45,0}},

                    {{23,45,0},
                    {23,45,0}},

                    {{23,45,0},
                    {23,45,0}}}, //2

                    {
                    {{23,45,0},
                    {23,45,0}},

                    {{23,45,0},
                    {23,45,0}},

                    {{23,45,0},
                    {23,45,0}},

                    {{23,45,0},
                    {23,45,0}}} //3

                };
                Console.WriteLine("thei is theanswer for the alternative way to declare it");

                Console.WriteLine("The matrix above has {0} number of rows", myArray.GetLength(0));
                Console.WriteLine("The matrix above has {0} number of columns", myArray.GetLength(1));
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
