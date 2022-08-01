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

        public static bool IdNumberControl(string idNumber)
        {
            if (idNumber.Length == 11)
            {
                foreach (var item in idNumber)
                {
                    if (!char.IsDigit(item))
                    {
                        return false;
                    }
                    else
                    {
                        //İşlem burda
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
