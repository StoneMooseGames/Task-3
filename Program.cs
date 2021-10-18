using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace task03
{
    
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }

               
}
class Person
{
    protected int personsAge;
    protected string personsName;

    public string Greet()
    {
        //Greet Person
        return ("hello " + personsName + "\n");
    }

    public void SetAge(int age)
    {
        //set age
        personsAge = age;
    }

    public void SetName(string name)
    {
        //set name
        personsName = name;
    }
}

class Student : Person
{

    public string Study()
    {
        //print "I'm studying student"
       return ("I'm studying student\n");
    }
    public string ShowAge()
    {
        //print "My age is: [x] years old"
        return ("My age is: " + personsAge + " years old");


    }
}

class Teacher : Person
{
    public string Explain()
    {
        //print "I'm a teaching teacher"
       return ("I'm a teaching teacher");
    }
}
}
                
  
