namespace SquareLibTests
{
    public class CircleTests
    {
        [Test]
        public void Square()
        {
            //ARRANGE
            var circle = new Сircle(2);
            double square;
            //ACT
            square = circle.Square();
            //ASSERT
            Assert.AreEqual(12.566370, Math.Round(square, 5));
        }
    }
}
