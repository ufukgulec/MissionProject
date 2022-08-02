using MissionProject;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTestApplicantValidator
    {
        [Fact]
        public void IdNumberControl()
        {//Tc kimlik numaras� kontrol�
            bool result = ApplicantValidator.IdNumberControl(12312312312);
            Assert.False(result);
        }
        [Fact]
        public void TechControl()
        {//Teknoloji kullan�m y�zdesi
            double result = ApplicantValidator.TechControl(3, 6);
            Assert.Equal(50, result);
        }
    }
}
