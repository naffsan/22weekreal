using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityLesson_CSharp_Operator
{
    static public class OperatorMethods
    {
        static public int Sum(int a, int b)
         { 
            return a + b; 
         }
        static public int MIN(int a, int b)
        {
            return a - b;
        }
        static public int Gop(int a, int b)
        {
            return a * b;
        }
        static public int Namum(int a, int b)
        {
            return a / b;
        }
        static public int Namuji(int a, int b)
        {
            return a % b;
        }
        static public int sum1(int a, int b)
        {
            return a ++;
        }
        static public int min1(int a, int b)
        {
            return a --;
        }
        static public bool LogSame(bool c, bool d)
        {
            return c == d;
        }

        static public bool LogDiffer(bool c, bool d)
        {
            return c != d;
        }
        static public int LogBigger(int a, int b)
        {
            return a > b;
        }

        static public bool LogicOr(bool A, bool B)
        { 
            return A | B; 
        }

        static public bool LogicAnd(bool A, bool B)
        {
            return A & B;
        }

        static public bool LogicXor(bool A, bool B)
        {
            return A ^ B;
        }
        static public bool LogicNot(bool A)
        {
            return !A ;
        }
        static public bool Logic_Or(bool A, bool B)
        {
            return A || B;
        }
        static public bool Logic_And(bool A, bool B)
        {
            return A && B;
        }
       
    }
}
