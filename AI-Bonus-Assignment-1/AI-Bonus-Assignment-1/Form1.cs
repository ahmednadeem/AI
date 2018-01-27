using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Bonus_Assignment_1
{
    public partial class Form1 : Form
    {
        int c = 0;
        bool jump = false;
        int speed = 10;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void timerScore_Tick(object sender, EventArgs e)
        {

            crow3.Location = new Point(crow3.Location.X - speed, crow3.Location.Y);
            crow1.Location = new Point(crow1.Location.X - speed, crow1.Location.Y);
            crow2.Location = new Point(crow2.Location.X - speed, crow2.Location.Y);
            road.Location = new Point(road.Location.X - speed, road.Location.Y);
            pictureBox10.Location = new Point(pictureBox10.Location.X - speed, pictureBox10.Location.Y);
            pictureBox11.Location = new Point(pictureBox11.Location.X - speed, pictureBox11.Location.Y);
            pictureBox12.Location = new Point(pictureBox12.Location.X - speed, pictureBox12.Location.Y);
            pictureBox6.Location = new Point(pictureBox6.Location.X - speed, pictureBox6.Location.Y);
            pictureBox5.Location = new Point(pictureBox5.Location.X - speed, pictureBox5.Location.Y);
            pictureBox9.Location = new Point(pictureBox9.Location.X - speed, pictureBox9.Location.Y);
            pictureBox7.Location = new Point(pictureBox7.Location.X - speed, pictureBox7.Location.Y);
            pictureBox8.Location = new Point(pictureBox8.Location.X - speed, pictureBox8.Location.Y);
            pictureBox13.Location = new Point(pictureBox13.Location.X - speed, pictureBox13.Location.Y);
            Invalidate();
            if (picDino.Bounds.IntersectsWith(pictureBox10.Bounds))
            {
                jump = true;
            }
            else if (picDino.Bounds.IntersectsWith(pictureBox11.Bounds))
            {
                jump = true;
            }
            else if (picDino.Bounds.IntersectsWith(pictureBox12.Bounds))
            {
                jump = true;
            }
            ////////////////////////////////////////////////////////////////////
            if (pictureBox10.Location.X < 11)
            {
                pictureBox10.Location = new Point(1000, pictureBox10.Location.Y);
            }
            if (pictureBox11.Location.X < 11)
            {
                pictureBox11.Location = new Point(1000, pictureBox11.Location.Y);
            }
            if (crow1.Location.X < 11)
            {
                crow1.Location = new Point(1000, crow1.Location.Y);
            }
            if (crow2.Location.X < 11)
            {
                crow2.Location = new Point(1000, crow2.Location.Y);
            }
            if (pictureBox12.Location.X < 11)
            {
                pictureBox12.Location = new Point(1000, pictureBox12.Location.Y);
            }
            if (crow3.Location.X < 11)
            {
                crow3.Location = new Point(1000, crow3.Location.Y);
            }
            if (pictureBox6.Location.X < 11)
            {
                pictureBox6.Location = new Point(1000, pictureBox6.Location.Y);
            }
            if (pictureBox5.Location.X < 11)
            {
                pictureBox5.Location = new Point(1000, pictureBox5.Location.Y);
            }
            if (pictureBox9.Location.X < 11)
            {
                pictureBox9.Location = new Point(1000, pictureBox9.Location.Y);
            }
            if (pictureBox7.Location.X < 11)
            {
                pictureBox7.Location = new Point(1000, pictureBox7.Location.Y);
            }
            if (pictureBox8.Location.X < 11)
            {
                pictureBox8.Location = new Point(1000, pictureBox8.Location.Y);
            }
            if (pictureBox13.Location.X < 11)
            {
                pictureBox13.Location = new Point(1000, pictureBox13.Location.Y);
            }
            if (jump)
            {
                if (c < 10)
                {
                    picDino.Location = new Point(picDino.Location.X, picDino.Location.Y - 9);
                    c++;
                }
                else if (c > 9 && c < 20)
                {
                    picDino.Location = new Point(picDino.Location.X, picDino.Location.Y + 9);
                    c++;
                }
                else
                {
                    jump = false;
                    c = 0;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}

