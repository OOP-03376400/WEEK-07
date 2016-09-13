using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSort
{
    public partial class Form1 : Form
    {
        List<Student> engedu;
        public Form1()
        {
            InitializeComponent();
            engedu = new List<Student>();
            dataGridView1.DataSource = engedu;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            engedu.Add(new Student() { Name = textBox1.Text, ID = Convert.ToInt32(textBox2.Text)});
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = engedu;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            engedu.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = engedu;
        }
    }

    class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CompareTo(Student other)
        {
            return other.ID.CompareTo(this.ID);
        }
    }
}
