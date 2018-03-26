using MVPSample.Models;
using MVPSample.Views;

namespace MVPSample.Presenters
{
    class RectanglePresenter
    {

        IRectangle rectangleview;

        public RectanglePresenter(IRectangle view)
        {
            this.rectangleview = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = double.Parse(rectangleview.WidthText);
            rectangle.Height = double.Parse(rectangleview.HeightText);

            rectangleview.AreaText = rectangle.CalculateSurface().ToString();
        }
    }
}
