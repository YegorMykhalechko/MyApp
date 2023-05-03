namespace MyConsoleApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void DifferentFloat_SholdReturnFalse()
        {
            float number1 = 2.5f;
            float number2 = 1.5f;

            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void DifferentString_SholdReturnFalse()
        {
            string name1 = "name";
            string name2 = "name2";

            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void DifferentInt_SholdReturnFalse()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            var user1 = GetUser("Yegor", "12345");
            var user2 = GetUser("user2", "12345");

            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            var user1 = GetEmployee("Yegor", "12345", 25);
            var user2 = GetEmployee("name", "surname", 25);

            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name, string password)
        {
            return new User(name, password);
        }

        private Employee GetEmployee(string firstName, string lastName, int age)
        {
            return new Employee(firstName, lastName, age);
        }
    }
}
