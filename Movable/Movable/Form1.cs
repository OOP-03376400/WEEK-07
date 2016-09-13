using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movable
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
            p.Walk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Run();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Swim();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Walk();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Run();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Swim();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fish f = new Fish();
            f.Walk();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fish f = new Fish();
            f.Run();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fish f = new Fish();
            f.Swim();
        }
    }

    public interface IMovable
    {
        void Walk();
        void Run();
        void Swim();
    }
    public class Person : IMovable
    {
        public void Walk()
        {
            MessageBox.Show("คนเดิน 2 ขา");
        }
        public void Run()
        {
            MessageBox.Show("คนวิ่ง 2 ขา");
        }
        public void Swim()
        {
            MessageBox.Show("คนว่ายน้ำ");
        }
    }

    public class Cat : IMovable
    {
        public void Walk()
        {
            MessageBox.Show("แมวเดิน 4 ขา");
        }
        public void Run()
        {
            MessageBox.Show("แมววิ่ง 4 ขา");
        }
        public void Swim()
        {
            MessageBox.Show("แมวไม่ชอบน้ำ");
        }

    }

    public class Fish : IMovable
    {
        public void Walk()
        {
            MessageBox.Show("ปลาเดินไม่ได้ ยกเว้นปลาตีน");
        }
        public void Run()
        {
            MessageBox.Show("ปลาวิ่งไม่ได้");
        }
        public void Swim()
        {
            MessageBox.Show("ปลาว่ายน้ำ");
        }

    }
}
