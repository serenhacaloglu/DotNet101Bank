using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dotnet101Bank.Test
{
    [TestClass]
    public class AtmTests
    {
        [TestMethod]
        public void withdraw_returns_false_for_minus_one()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = false;
            //Act 
            bool actualResult =atm.WithDraw(-1);
            //Assert
            Assert.AreEqual(expectedResult,actualResult);

        }

        [TestMethod]
        public void withdraw_returns_false_for_zero()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = false;
            //Act 
            bool actualResult = atm.WithDraw(0);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void withdraw_returns_false_for_one()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = false;
            //Act 
            bool actualResult = atm.WithDraw(1);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void withdraw_returns_false_for_fourtythree()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = false;
            //Act 
            bool actualResult = atm.WithDraw(43);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void withdraw_returns_false_for_seventeen()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = false;
            //Act 
            bool actualResult = atm.WithDraw(17);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void withdraw_returns_true_for_five()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = true;
            //Act 
            bool actualResult = atm.WithDraw(5);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void withdraw_returns_true_for_twenty()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = true;
            //Act 
            bool actualResult = atm.WithDraw(20);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void withdraw_returns_true_for_thirtyfive()
        {
            //Arrange
            Atm atm = new Atm();
            bool expectedResult = true;
            //Act 
            bool actualResult = atm.WithDraw(35);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



    }
}
