using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Players
    {
        public string name;
        public string gesture;

        public Players()
        {
            
        }
    }

    public class Human : Players
    { 
        public Human(string name)
        {
            this.name = name;
        }
        
    }

    public class CPU : Players
    {
        public CPU(string name)
        {
            this.name = name;
        }
    }
}
