using MissionProject;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTestValidator
    {
        [Fact]
        public void TestAgeControl()
        {//Yaþ 0'dan büyük olmak zorunda
            bool result = Validator.AgeControl(19);
            Assert.True(result);
        }
        [Fact]
        public void IdNumberControl()
        {//Tc 11 hane olmak zorunda
            bool result = Validator.IdNumberControl(12);
            Assert.False(result);
        }
        [Fact]
        public void ExpControl()
        {//Deneyim yaþtan küçük olmak zorunda
            bool result = Validator.ExpControl(2, 24);
            Assert.True(result);
        }
    }
}
