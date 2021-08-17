using System;


namespace OPPDemo
{
    //  This class contains functions for prove polymorphism
    class MyMath
    {
         // This fun adds to numbers
        public int Add(int num1,int num2)
        {
            //  Arithmetic expression
            return num1 + num2;
        }

        //  This function combining two strings
        public string Add(string str1,string str2)
        {
            //  String expression
            return string.Format("{0}",str1+str2);
        }

        public virtual int Increment(int x)
        {
            x++;
            return x;
        }
    }
    class MyMath1 : MyMath
    {
        public override int Increment(int x)
        {
            x = x + 5;
            return x;
        }

        // This is shadow of Add() functions from MyMath
        public double Add(double d1, double d2)
        {
            return d1 + d2;
        }
    }
}
