using NUnit.Framework;


namespace ConsoleAppTestPlayer
{
    [TestFixture]
    public class PlayerHandling
    {
        [Test]
        public void TestOne()
        {
            foreach (var Player in Program.Playerlist())
            {
                Assert.IsNotNull(Player.PlayerId);
                Assert.IsNotNull(Player.PlayerName);
                Assert.IsNotNull(Player.PlayerTeam);

            }
        }
    }
}
