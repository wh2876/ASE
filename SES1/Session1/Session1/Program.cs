using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
        }

        public Program()
        {
            while (true)
            {
                float h = 0;
                float w = 0;
                bool f = false;

                while (true)
                {
                    try
                    {
                        MessageBox.Show("Please enter your height in meters", "Hi_0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        h = Single.Parse(Console.ReadLine());
                        if (h > 0) break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid response.");
                    }
                } 

                while (true) {
                    try
                    {
                        MessageBox.Show("Please enter your weight in kg", "Hi_1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        w = Single.Parse(Console.ReadLine());
                        if( w > 0 ) break;
                    }
                    catch (Exception ex) {
                        Console.WriteLine("Invalid response.");
                    }
                }
                while (true)
                {
                    MessageBox.Show("Please enter your sex:", "Hi_1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    String sex = Console.ReadLine().ToLower();
                    if (sex == "female") break;
                    else if (sex == "male") break;
                    else
                    {
                        Console.WriteLine("Please only input \"male\" or \"female\"");
                    }
                }
                MessageBox.Show("You are " + BMIGrade(calculateBMI(h, w), f), "Hi_1", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public float calculateBMI(float height, float weight)
        {
            return weight / (height * height);
        }

        public String BMIGrade(float BMI, bool female)
        {
            if (BMI < 17.5 && female) return "severely underweight";
            else if (BMI < 18.5 && !female) return "severely underweight";
            else if (BMI <= 19.1 && female) return "underweight";
            else if (BMI <= 20.7 && !female) return "underweight";
            else if (BMI <= 25.8 && female) return "in normal range";
            else if (BMI <= 26.4 && !female) return "in normal range";
            else if (BMI <= 27.3 && female) return "overweight";
            else if (BMI <= 27.8 && !female) return "overweight";
            else if (BMI <= 32.3 && female) return "marginally overweight";
            else if (BMI <= 31.1 && !female) return "marginally overweight";
            else if (BMI <= 35) return "very overweight or obese";
            else if (BMI <= 40) return "severely obese";
            else if (BMI <= 50) return "morbidly obese";
            else if (BMI <= 60) return "super obese";
            else return "mind blowingly obese";
        }

    }
}
