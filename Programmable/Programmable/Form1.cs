using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Programming();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Programmer p = new Programmer();
            p.Programming();
        }
    }

    public interface IProgrammable
    {
        void Programming();
    }

    class Person : IProgrammable
    {
        public void Programming()
        {
            MessageBox.Show("เขียนโปรแกรมแบบธรรมดาๆ ");
        }
    }

    class Programmer : IProgrammable
    {
        public void Programming()
        {
            MessageBox.Show("เขียนโปรแกรมอย่างเทพ");
        }
    }


}
