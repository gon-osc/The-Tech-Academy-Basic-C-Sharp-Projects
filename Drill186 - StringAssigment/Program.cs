﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill186___StringAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase1 = "Welcome To";
            string phrase2 = " 2020's";
            string phrase3 = " Athletic Club Championships!";

            Console.WriteLine(phrase1 + phrase2 + phrase3);

            Console.WriteLine("What is you first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is you last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What state are you from?");
            string homeState = Console.ReadLine();
            homeState = homeState.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append("Welcome " + firstName);
            sb.Append(" "+lastName);
            sb.Append(" from ");
            sb.Append(homeState + ".");
            sb.AppendLine();
            sb.Append("How can we help you today?");


            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
