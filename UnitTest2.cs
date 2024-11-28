using System.Runtime.Intrinsics.X86;
using Xunit;
using Mihail;

namespace TestNameSpace
{


    public class UnitTest1
        {
        [Fact]
        public void Test1()
            {
                //Mihail.MyPoint m = new(rectangle);
            MyPoint p1 = new MyPoint (0, 0);
            MyPoint p2 = new MyPoint(0, 1);
            MyPoint p3 = new MyPoint(1, 1);
            MyPoint p4 = new MyPoint (1, 0);
            MyFigure rectangle = new MyFigure (p1, p2, p3, p4);
            double expectedPerimeter = Math.Sqrt(2) + 1 + 1; // Расчет ожидаемого периметра

            //if (expectedPerimeter == rectangle.PerimeterCalculator);

            //Assert.Equal(expectedPerimeter, rectangle.PerimeterCalculator());
            }
        }
}