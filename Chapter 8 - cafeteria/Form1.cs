using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter_8___cafeteria
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine;
        public Form1()
        {
            InitializeComponent();
            breakfastLine = new Queue<Lumberjack>();
            RedrawList();
        }

        private void btnAddLumberjack_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                Console.WriteLine("Enter a name to enter the breakfast line");
                return;
            }
            breakfastLine.Enqueue(new Lumberjack(txtName.Text));
            RedrawList();
        }

        private void btnAddFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0)
                return;
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
            {
                food = Flapjack.Banana;
            }

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)numFood.Value);
            nextInLine.Text = $"{currentLumberjack.Name} has {currentLumberjack.FlapjackCount} flapjacks";
            RedrawList();
        }

        private void RedrawList()
        {
            txtName.Text = string.Empty;
            line.Items.Clear();
            int numberInLine = 1;
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                string item = $"{numberInLine}. {lumberjack.Name}";
                line.Items.Add(item);
                numberInLine++;
            }

            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currenLumberjack = breakfastLine.Peek();
                nextInLine.Text = $"{currenLumberjack.Name} has {currenLumberjack.FlapjackCount} flapjacks.";
            }
        }

        private void btnNextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = String.Empty;
            RedrawList();
        }
    }
}
