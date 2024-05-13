using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustNumber
{
    internal class SearchJastNumber
    {   
        public string Calcucation(int jastNumber)
        {
            int _number = 1;
            int _count = 0;
            string _jastNumber = "";

            while (_count < jastNumber)
            {
                _number++;
                if (IsPrime(_number))
                {
                    _jastNumber += _number + ", ";
                    _count++;
                }
            }
            return _jastNumber;
        }

        public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
