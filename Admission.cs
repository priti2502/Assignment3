using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Admission
    {
        public void displayEligibleStudent()
        {
            int MathMarks = 72;
            int PhyMarks = 65;
            int ChemMarks = 51;

            int Total=MathMarks + PhyMarks + ChemMarks; 

            int MathPhyTotal=MathMarks  + PhyMarks;

            if((MathMarks>=65 && PhyMarks>=55 &&  ChemMarks>= 50) && (Total>=180 || MathPhyTotal >= 180))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }

        }
    }
}