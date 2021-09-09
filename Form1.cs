using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class b : Form
    {
        public b()
        {
            InitializeComponent();
        }


        String[] Array = { "剪刀", "石頭", "布" };


        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = button.Text;
            Random random = new Random();
            int number = random.Next(0, 3);
            label3.Text = Array[number];
            Result(button.Text, Array[number]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "石頭";
            Random random = new Random();
            int number = random.Next(0, 3);
            label3.Text = Array[number];
            Result("石頭", Array[number]);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "布";
            Random random = new Random();
            int number = random.Next(0, 3);
            label3.Text = Array[number];

            Result("布", Array[number]);

        }

        public void Result(String player, String com)
        {
            
            if (player == com)
            {
                MessageBox.Show("平手");
            }
            else if (player == "剪刀" && com == "布" || player == "布" && com == "石頭")
            {
                MessageBox.Show("你贏了", "結果", MessageBoxButtons.RetryCancel);
                int score = int.Parse(playerScore.Text) + 1;
                playerScore.Text = score.ToString();
            }
            
            else
            {
                MessageBox.Show("你輸了");
                int score = int.Parse(computerScore.Text) + 1;
                computerScore.Text = score.ToString();
            }
            
        }


            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
