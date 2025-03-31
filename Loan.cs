using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsContinuedAbstractDemo
{
   public class Loan
    {

        public int LoanID { get; set; }
        public string loanType { get; set; }

        public double loanAmt { get; set; }

        public int Tenure { get; set; }




    }

   public class HomeLoan : Loan
    {
        public float ROI { get; set; }
        public virtual double calculateEMI(double loanAmt,int Tenure, float ROI)
        {
            double emi=0;
            return emi;
        }

    }

  public  class PersonalLoan : HomeLoan
    {
        public override double calculateEMI(double loanAmt, int Tenure, float ROI)
        {
            double emi=0;
            return emi;
        }


    }

}
