using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPDemo
{
   static  class GstStat
    {
        static GstStat()
        {
            Console.WriteLine("constrctor of static class");
        }
        public static double GstAmt(double ProAmount,double GstPer)
        {
            double GstAmount = ProAmount / 10 * GstPer;
            return GstAmount;
        }

        public static double TotalAmount(double ProAmount, double GstPer)
        {
            double GstAmount = GstAmt(ProAmount, GstPer);
            double totalAmount = ProAmount + GstAmount;
            return totalAmount;
        }
    }
}
