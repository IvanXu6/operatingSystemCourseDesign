using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 操作系统模拟系统
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IvanXu6");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IvanXu6/Operating-system-course-design");
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/zh-cn/dotnet/core/introduction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.163.com/");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            processScheduing processScheduing = new processScheduing();
            processScheduing.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            processSynchronization processSynchronization =new processSynchronization();
            processSynchronization.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            if (this != main)
                Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            processDeadlockHandling processDeadlockHandling =new processDeadlockHandling();
            processDeadlockHandling.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MemoryAllcation memoryAllcation =new MemoryAllcation();
            memoryAllcation.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
