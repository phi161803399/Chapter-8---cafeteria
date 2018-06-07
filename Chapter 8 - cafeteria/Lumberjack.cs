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
            get { return -1; }
        }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            // Add some number of flapjacks to the Meal stack
        }

        public void EatFlapjacks()
        {
            string output = $"{Name}'s eating flapjacks";
            foreach (Flapjack food in meal)
            {
                output += $"{Name} ate a {meal.Pop().ToString().ToLower()} flapjack";
            }
            Console.WriteLine(output);
        }
    }
}
