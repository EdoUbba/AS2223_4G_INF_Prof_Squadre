using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            Assert.That(Player.ERole.Rosa, Is.True);
        }

        [Test]
        public void AddCaptain()
        {
            // TODO U.2
        }
    }
}