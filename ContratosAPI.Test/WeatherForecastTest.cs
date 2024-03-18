namespace ContratosAPI.Test
{
    public class WeatherForecastTest
    {
        [Fact]
        public void TestGet()
        {
            //Arrange 
            var controller = new Controllers.WeatherForecastController();

            //Act
            var ret = controller.Get();

            //Assert
            Assert.NotNull(ret);

        }
    }
}