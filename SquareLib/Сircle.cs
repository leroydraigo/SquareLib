namespace SquareLib
{
    public class Сircle : IFigure
    {
        public double radius;

        public Сircle() { }
        public Сircle(double radius) 
        {
            this.radius = radius;
        }

        public double Square()
        {
            return Math.PI * radius * radius;
        }
    }
}
