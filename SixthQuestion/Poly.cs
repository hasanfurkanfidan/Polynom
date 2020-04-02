using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthQuestion
{
    class Poly
    {
        string equation;
        public int a;
        public void createpoly(int a)
        {
            if(a<2)
            {
                equation =  "Error";
            }
            if(a==2)
            {
                equation = "a*x*x+b*x+c";
            }
            if(a==3)
            {
                equation = "a*x*x*x+b*x*x+c*x+d";
            }
            if(a==4)
            {
                equation = "a*x*x*x*x+b*x*x*x+c*x*x+d*x+e";
            }
            if (a == 5)
            {
                equation = "a*x*x*x*x*x+b*x*x*x*x+c*x*x*x+d*x*x+e*x+f";
            }
                

        }
        public string equ()
        {
            createpoly(a);
            return equation;
        }
            
    }
}
