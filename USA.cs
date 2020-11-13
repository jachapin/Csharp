using System;
using System.Collections.Generic;

namespace UnitedStates
{

    /// <summary>
    /// Author: Jeff Chapin - 2020
    /// The USA class allows a user to create a list of American states
    /// </summary>
    class USA
    {

        static List<State> states = new List<State>();
        static void Main(string[] args)
        {
            bool asking = true;

            while(asking)
                {
                Console.WriteLine("Enter state name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter state year");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter state capital:");
                string Capital = Console.ReadLine();

                states.Add(new State(Name, Year, Capital));

                Console.WriteLine("Add another state? Y/N");
                string response = Console.ReadLine().ToLower();

                if(response == "n")
                {
                    asking = false;
                }
                else
                {
                    continue;
                }
            }

            foreach (var state in states)
            {
                Console.WriteLine(state.ToString());
            }
           
        }
    }

    class State
    {
        static int TotalStates;

        public int Index;
        protected string Name;
        protected int Year;
        protected string Capital;
        

        public State()
        {

        }

        public State(string name, int year, string capital)
        {
            Name = name;
            Year = year;
            Capital = capital;
            TotalStates++;
        }

        public State(int index, string name, int year, string capital)
        {
            Index = index;
            Name = name;
            Year = year;
            Capital = capital;
            TotalStates++;

        }

        override public String ToString()
        {
            return Name + " " + Year + " " + Capital;
        }

    }
}
