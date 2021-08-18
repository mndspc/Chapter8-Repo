using System;


namespace OPPDemo
{
   sealed class Gst
    {
        public double ProAmount { get; set; }

        public double GstPer { get; set; }

        public Gst(double proAmt,double gstPer)
        {
            ProAmount = proAmt;
            GstPer = gstPer;
        }
        public double GstAmt()
        {
            double GstAmount = ProAmount / 10 * GstPer;
            return GstAmount;
        }

        public double TotalAmount()
        {
            double GstAmount = GstAmt();
            double totalAmount = ProAmount + GstAmount;
            return totalAmount;
        }
    }

   
}
