namespace SquareLibTests
{
    public class Tests
    {
        [Test]
        public void Triangle_isRightAngled()
        {
            //ARRANGE
            var trainge = new Triangle(3, 4, 5);
            bool isRightAngled;
            //ACT
            isRightAngled = trainge.isRightAngled();
            //ASSERT
            Assert.AreEqual(true, isRightAngled);
        }


        [Test]
        public void Square()
        {
            //ARRANGE
            var trainge = new Triangle(8, 4, 5);
            double square;
            //ACT
            square = trainge.Square();
            //ASSERT
            Assert.AreEqual(8.181534, Math.Round(square,6));
        }
    }
}