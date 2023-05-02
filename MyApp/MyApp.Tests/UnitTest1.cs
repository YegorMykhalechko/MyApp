namespace MyConsoleApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldCorrectResult()
        {
            var user = new Employee("name", "surname", 18);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-1);

            var result = user.Result;

            Assert.AreEqual(10, result);
        }
    }
}