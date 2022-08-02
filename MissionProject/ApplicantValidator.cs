using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionProject
{
    public static class ApplicantValidator
    {
        public static string[] techs = { "C#", "HTML", "JS", "MSSQL", "ALGORITHM", "DATA STRUCTURE" };
        public static bool IdNumberControl(long idNum)
        {
            List<int> idList = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                idList.Add(Convert.ToInt32(idNum % 10));
                idNum = idNum / 10;
            }
            idList.Reverse();

            int Digit10 = ((idList[0] + idList[2] + idList[4] + idList[6] + idList[8]) * 7 + (idList[1] + idList[3] + idList[5] + idList[7]) * 9) % 10;
            int Digit11 = ((idList[0] + idList[2] + idList[4] + idList[6] + idList[8]) * 8) % 10;


            if (Digit10 == idList[9] && Digit11 == idList[10])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double TechControl(double availableTechCount)
        {
            double tky = 100 / (6.0 / availableTechCount);
            return tky;
        }
    }
}
