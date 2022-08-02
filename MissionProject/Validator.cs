using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionProject
{
    public static class Validator
    {
        public static bool AgeControl(int Age)
        {
            if (Age > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IdNumberControl(long idNumber)
        {
            if (idNumber > 10000000000 && idNumber < 99999999999)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool ExpControl(double exp, int age)
        {
            if (age > exp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
