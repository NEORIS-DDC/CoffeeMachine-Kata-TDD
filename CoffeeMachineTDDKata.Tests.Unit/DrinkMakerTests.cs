using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachineTDDKata.Tests.Unit
{
    //http://simcap.github.io/coffeemachine/cm-first-iteration.html
    [TestClass]
    public class DrinkMakerTests
    {
        private DrinkMaker Target;

        [TestInitialize]
        public void Init()
        {
            this.Target = new DrinkMaker();
        }

        [TestMethod]
        public void When_Drink_Maker_Receives_T_1_0_Drink_Coffee_Machine_Makes_A_Tea_With_One_Sugar_And_A_Stick()
        {
            //Arrange
            var messageExpected = "(Drink maker makes 1 tea with 1 sugar and a stick)";

            //Act
            var result = this.Target.Make("T:1:0");

            //Assert
            Assert.AreEqual(result, messageExpected);
        }

        [TestMethod]
        public void When_Drink_Maker_Receives_H_empty_empty_Drink_Coffee_Machine_Makes_A_Chocolate_With_No_Sugar_And_No_Stick()
        {
            //Arrange
            var messageExpected = "(Drink maker makes 1 chocolate with no sugar and therefore no stick)";

            //Act
            var result = this.Target.Make("H::");

            //Assert
            Assert.AreEqual(result, messageExpected);
        }

        [TestMethod]
        public void When_Drink_Maker_Receives_C_2_0_Drink_Coffee_Machine_Makes_A_Coffee_With_2_Sugar_And_a_Stick()
        {
            //Arrange
            var messageExpected = "(Drink maker makes 1 coffee with 2 sugars and a stick)";

            //Act
            var result = this.Target.Make("C:2:0");

            //Assert
            Assert.AreEqual(result, messageExpected);
        }
    }
}