using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Timer_demo
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Stopwatch mywatch = new Stopwatch();
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void counttimer_Tick(object sender, EventArgs e)
        {
            counter++;
            Countlable.Text = $"{counter}"; 
           
            if(counter % 2 ==0)
            {
                if (colorlable.BackColor == Color.Red)
                {
                    colorlable.BackColor = Color.Red;
                }

                else if (colorlable.BackColor == Color.Red)
                {
                    colorlable.BackColor = Color.Green;
                }
                else
                {
                    colorlable.BackColor = Color.Red;
                }
            }
           
        }

       
        private void start_Click(object sender, EventArgs e)
        {
            if(!counttimer.Enabled)
            {
                counttimer.Enabled = true;
                mywatch.Start();

            }

            else
            {
                counttimer.Enabled = false;
               timelable.Text = mywatch.Elapsed.ToString(@"\:ff");
                //timelable.text = mywatch.elapsedmilliseconds
                //timelable.text = mywatch.elapsed + "";
            }

        }
    }
}
