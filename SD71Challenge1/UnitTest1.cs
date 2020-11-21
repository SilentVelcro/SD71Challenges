using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SD71Challenge1
{
    [TestClass]
    public class WeekOne
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "Supercalifragilisticexpialidocious";

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            string name = "Supercalifragilisticexpialidocious";

            for (int i = 0; i < name.Length; i++)
            {

                if ("i".IndexOf(name[i]) >= 0)
                    Console.Write("I");

                if ("Supercalfraglstcexpaldocous".IndexOf(name[i]) >= 0)
                    Console.Write("Not an i");

                if ("l".IndexOf(name[i]) >= 0)
                    Console.Write("L");
            }
        }
        [TestMethod]
        public void MyTestMethod3()
        {
            string firstName = "Nikki";
            string lastName = "Grostefon";
            int myAge = 40;

            Console.WriteLine(myAge + 7);
            Console.WriteLine(myAge * 7);
            Console.WriteLine(myAge % 7);
            Console.WriteLine(myAge / 7);
            Console.WriteLine(myAge - 7);
        }
        [TestMethod]
        public void MyTestMethod4()
        {
            string[] movie = { "Natural Born Killers", "Reservoir Dogs", "Forrest Gump", "Goodfellas" };
        }
        [TestMethod]
        public void MyTestMethod5()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime dayOne = DateTime.Now;
            DateTime dayTwo = new DateTime(2019, 2, 10);
            DateTime dayThree = new DateTime(2020, 2, 15);
            DateTime dayFour = new DateTime(2015, 12, 21);
            listOfDates.Add(dayOne);
            listOfDates.Add(dayTwo);
            listOfDates.Add(dayThree);
            listOfDates.Add(dayFour);

        }
        [TestMethod]
        public void MyTestMethod7()
        {
            int sleepNumber = 6;

            if (sleepNumber >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (sleepNumber < 10 && sleepNumber >= 8)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (sleepNumber > 4 && sleepNumber < 8)
            {
                Console.WriteLine("Bummer!!!");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }
        [TestMethod]
        public void MyTestMethod8()
        {
            int dayRate = 2;

            switch (dayRate)
            {
                case 5:
                    Console.WriteLine("Great");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 2:
                    Console.WriteLine("Bad");
                    break;
                case 1:
                    Console.WriteLine(":(");
                    break;
            }
        }
    }
}
