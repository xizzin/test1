
using parawork;


namespace TestProject1
{
    [TestClass]
    public class PasswordCheckerTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestZeroLevels()
        {
            int level = PasswordChecker.CheckCheck(" ");
            Console.WriteLine(level);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestOneLevel()
        {
            int level = PasswordChecker.CheckCheck("f");
            Console.WriteLine(level);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTwoLevels()
        {
            int level = PasswordChecker.CheckCheck("f!");
            Console.WriteLine(level);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThreeLevels()
        {
            int level = PasswordChecker.CheckCheck("fF!");
            Console.WriteLine(level);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFourLevels()
        {
            int level = PasswordChecker.CheckCheck("fF1!");
            Console.WriteLine(level);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFiveLevels()
        {
            int level = PasswordChecker.CheckCheck("fFaaaaaaa1!");
            Console.WriteLine(level);
        }
    }
}