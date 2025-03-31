using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsContinuedAbstractDemo
{
    public class Developer : Employee
    {
        string _desig;
        public override string Designation { get { return _desig; } set { _desig = value; } }

        public double TotalSalary { get; set; } //Property
        public override void CalculateSalary(int bs)
        {
            double Sal;
            // throw new NotImplementedException();
            if (Designation == "FrontEndDeveloper")
            {
                Sal = bs + (bs * .10);

            }
            else if (Designation == "BackEndDeveloper")
            {
                Sal = bs + (bs * .15);

            }
            else
            {
                Sal = bs + (bs * .30);
            }
            TotalSalary = Sal;//set of Total Salary is called
        }
    }
}
