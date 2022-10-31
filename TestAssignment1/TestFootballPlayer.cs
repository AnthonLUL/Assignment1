using Assignment1;
using System.ComponentModel.DataAnnotations;

namespace TestAssignment1
{
    [TestClass]
    public class TestFootballPlayer
    {
        private FootballPlayer footballPlayer = new FootballPlayer { Id = 1, Name = "Anthon", Age = 22, ShirtNumber = 10};
        private FootballPlayer footballPlayerAgeAge1 = new FootballPlayer { Id = 2, Name = "Peter", Age = 1, ShirtNumber = 11};
        private FootballPlayer footballPlayerNameNull = new FootballPlayer { Id = 3, Name = null, Age = 21, ShirtNumber = 13};
        private FootballPlayer footballPlayerShirtnum1 = new FootballPlayer { Id = 4, Name = "A", Age = 24, ShirtNumber = 1};
      

        [TestMethod()]
        public void ValidateNameTest()
        {
            footballPlayer.ValidateName();
            Assert.ThrowsException<ArgumentNullException>(() => footballPlayerNameNull.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => footballPlayerShirtnum1.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            footballPlayer.ValidateAge();
            Assert.ThrowsException<ArgumentException>(() => footballPlayerAgeAge1.ValidateAge());

        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(55)]
        [DataRow(98)]
        [DataRow(99)]
        public void ValidateShirtNumberTest(int shirtNum)
        {
            footballPlayer.ShirtNumber = shirtNum;
            footballPlayer.ValidateShirtNum();
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(100)]
        [DataRow(101)]

        public void ValidateShirtNumberReturnsFalse(int shirtNum)
        {
            footballPlayerShirtnum1.ShirtNumber = shirtNum;
            Assert.ThrowsException<ArgumentException>(() => footballPlayerShirtnum1.ValidateShirtNum());
        }

        //[TestMethod()]
        //public void ValidateTest() 
        //{
        //    footballPlayer.Validate();
        //    Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerAgeNegative.Validate());
        //    Assert.ThrowsException<ArgumentNullException>(() => footballPlayerNameNull.Validate());
        //    Assert.ThrowsException<ArgumentException>(() => footballPlayerNameIncludesNum.Validate());
        //}
        //public void TestNameContainingTwoOrMoreCharacters()
        //{
        //    //arrange
        //    string nameToCheck = "Anthon";
        //    string expectedResult = "Anthon";

        //    Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();

        //    //act
        //    string actualResult = footballPlayer.TestNameConstraint();

        //    //assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void TestNameContainingOneCharacter()
        //{
        //    //arrange
        //    string nameToCheck = "A";
        //    string expectedResult = "A";

        //    Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();
        //    try
        //    {
        //        footballPlayer.TestNameConstraint();
        //    }
        //    catch(System.ArgumentException)
        //    {
        //        return;
        //    }

        //    //act
        //    string actualResult = footballPlayer.TestNameConstraint();

        //    //assert
        //    Assert.Fail(actualResult);
        //}

        //[DataTestMethod]
        //[DataRow("A1")]
        //public void TestNameContainingOneNumberOneLetter(string name)
        //{
        //    //arrange
        //    string nameToCheck = "A1";
        //    string expectedResult = "A1";

        //    Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();
        //    try
        //    {
        //        footballPlayer.TestNameConstraint();
        //    }
        //    catch (System.ArgumentException)
        //    {
        //        return;
        //    }

        //    //act
        //    string actualResult = footballPlayer.TestNameConstraint(nameToCheck);

        //    //assert
        //    Assert.Fail(actualResult);
        //}

        //[DataTestMethod]
        //[DataRow(3)]
        //public void TestAge(int age)
        //{
        //    //arrange
        //    int ageToCheck = 3;
        //    int expectedResult = 3;

        //    Assignment1.FootballPlayer footballPlayer = new Assignment1.FootballPlayer();

        //    //act
        //    int actualResult = footballPlayer.TestAgeConstraints(age, expectedResult);

        //    //assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}


    }
}

