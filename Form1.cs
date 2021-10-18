using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace task03
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
                                   
        }

        
        private void button1_Click(object sender, EventArgs e)//Done button
        {
            WhosWho();   
        }

        public void WhosWho()
        {

            //checkbox1 = teacher
            //checkbox2 = student
            //label3 = outputbox
            //textbox1 = Name
            //textbox2 = Age
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Give a name and an age";
                return;
            }
            Person newPerson = new Person();
            newPerson.SetName(textBox1.Text);
            newPerson.SetAge(Int32.Parse(textBox2.Text));
            label3.Text = newPerson.Greet();

            if (checkBox2.Checked && checkBox1.Checked)
            {
                label3.Text = "You can't be both student and a teacher";
                return;
            }

                if (checkBox2.Checked && !checkBox1.Checked)
            {
                Student student = new Student();

                student.SetName(textBox1.Text);
                student.SetAge(Int32.Parse(textBox2.Text));
                label3.Text = student.Greet();
                label3.Text += student.Study();
                label3.Text += student.ShowAge();
            }

            if (checkBox1.Checked && !checkBox2.Checked)
            {
                Teacher teacher = new Teacher();

                teacher.SetName(textBox1.Text);
                teacher.SetAge(Int32.Parse(textBox2.Text));
                label3.Text = teacher.Greet();
                label3.Text += teacher.Explain();

            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            label3.Text = "";
        }
    }
}
