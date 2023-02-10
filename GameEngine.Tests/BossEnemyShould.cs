namespace GameEngine.Tests
{
    public class BossEnemyShould
    {

        private readonly ITestOutputHelper _output;

        public BossEnemyShould(ITestOutputHelper output)
        {
            _output = output;
        }


        //FloatingPointAsserts

        [Fact]
        [Trait("Category","Boss")] // Categories TEsts
        public void HaveCorrectPower()
        {

            _output.WriteLine("Test Boss output");

            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
    }
}
