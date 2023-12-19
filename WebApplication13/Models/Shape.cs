namespace WebApplication13.Models
{
    //開放封閉原則 (Open/Closed Principle, OCP)
    //形狀的面積算法不固定
    //抽象讓繼承去實作他
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side;
        }
    }
    public class AreaCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
