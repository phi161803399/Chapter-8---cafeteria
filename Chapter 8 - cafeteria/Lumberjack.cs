using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_8___cafeteria
{
    class Lumberjack
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private Stack<Flapjack> meal;

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount
        {
            get { return meal.Count; }
        }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            // Add some number of flapjacks to the Meal stack
            for (int i = 0; i < howMany; i++)
                meal.Push(food);
        }

        public void EatFlapjacks()
        {
            //int initialCount = FlapjackCount;
            //string output = $"{Name}'s eating flapjacks" + Environment.NewLine;
            //for (int i = 0; i < initialCount; i++)
            //{
            //    output += $"{Name} ate a {meal.Pop().ToString().ToLower()} flapjack" + Environment.NewLine;
            //}
            //Console.WriteLine(output);
            string output = string.Empty;
            if (FlapjackCount == 0)
                output += $"{Name} doesn't like flapjacks" + Environment.NewLine;
            else
            {
                output += $"{Name}'s eating flapjacks" + Environment.NewLine;
                while (FlapjackCount > 0)
                {
                    output += $"{Name} ate a {meal.Pop().ToString().ToLower()} flapjack" + Environment.NewLine;
                }
            }
            Console.WriteLine(output);
        }
    }
}
