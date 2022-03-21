using System;

namespace institute
{
    class person
    {
        static void Main(string[] args)
        {
            student sample = new daughter();          // (student)reference class--->followed by default constructor(daughter) // Convert from daughter to student 
            mem test = new daughter();               //   student---> daughter 
                                                    // multi level       
            test.fig();
        }
    }
    public class daughter : student
    {
        public override void fig()
        {
            base.fig();
            Console.WriteLine("venky");
        }

    }
    public class student : mem
    {
        public override void fig()
        {
            base.fig();
            Console.WriteLine("welcome");

        }


    }
    public class mem
    {
        public virtual void fig()
        {
            Console.WriteLine("88888");
        }


    }


}

