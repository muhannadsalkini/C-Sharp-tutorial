﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Week5_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*************** example 1 **************/
            Queue p1 = new Queue()
            {

            }

            var users = new ArrayList()
            {
                1,
                "ahmet mehmet",
                "7/10/1974",

                2,
                "mahmut mehmet",
                "7/10/1974",

                3,
                "muhannad salkini",
                "7/10/1974",

                4,
                "majd salkini",
                "7/10/1974",

                5,
                "abdullah salkini",
                "7/10/1974",

            };

            for (int i = 0; i < users.Count; i++)
            {

            }
                
            foreach (var item in users)
            {
                Console.Write(item + ", ");
            }

            Console.ReadKey();

        }
    }
}
