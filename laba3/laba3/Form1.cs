using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba3
{
    public partial class Form1 : Form
    {


        ArrayList Student, res;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Student = new ArrayList();
            res = new ArrayList();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int num = dataGridView1.SelectedRows[0].Index;
                Student.RemoveAt(num);
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            catch
            {
                MessageBox.Show("Выберите строку!!!!!!!!!!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int Rost = (int) numericUpDown1.Value;
            int Ves = (int) numericUpDown2.Value;
            Student p = new Student (name, Rost, Ves);
            Student student = new Student(name, Rost, Ves);
            Student.Add(student);
            dataGridView1.Rows.Add(name, Rost, Ves);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            res.Sort();
            dataGridView1.Rows.Clear();
            foreach (Student student in res)
            dataGridView2.Rows.Add(student.Name, student.Rost, student.Ves);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
