using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_32_ThanhLam
{
    
    public class Calculation_32_Lam
    {
        private int a, b;
        public Calculation_32_Lam(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double Excute_32_Lam(string Cal)
        {
            double result32 = 0;
            switch (Cal)
            {
                case "(A+B)^2":
                    result32 = Math.Pow(this.a, 2) + 2 * this.a * this.b + Math.Pow(this.b, 2);
                    break;
                case "(A-B)^2":
                    result32 = Math.Pow(this.a, 2) - 2 * this.a * this.b + Math.Pow(this.b, 2);
                    break;
                case "A^2 - B^2":
                    result32 = (this.a - this.b) * (this.a + this.b);
                    break;
                case "(A+B)^3":
                    result32 = Math.Pow(this.a, 3) + 3 * Math.Pow(this.a, 2) * this.b + 3 * this.a * Math.Pow(this.b, 2) + Math.Pow(this.b, 3);
                    break;
                case "(A-B)^3":
                    result32 = Math.Pow(this.a, 3) - 3 * Math.Pow(this.a, 2) * this.b + 3 * this.a * Math.Pow(this.b, 2) - Math.Pow(this.b, 3);
                    break;
                case "A^3 + B^3":
                    result32 = (this.a + this.b) * (Math.Pow(this.a, 2) - this.a * this.b + Math.Pow(this.b, 2));
                    break;
                case "A^3 - B^3":
                    result32 = (this.a - this.b) * (Math.Pow(this.a, 2) + this.a * this.b + Math.Pow(this.b, 2));
                    break;
            }
            return result32;
        }
    }
}
