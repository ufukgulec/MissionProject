using MissionProject;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTestValidator
    {
        [Fact]
        public void TestAgeControl()
        {//Ya� 0'dan b�y�k olmak zorunda
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
        {//Deneyim ya�tan k���k olmak zorunda
            bool result = Validator.ExpControl(2, 24);
            Assert.True(result);
        }
    }
}
