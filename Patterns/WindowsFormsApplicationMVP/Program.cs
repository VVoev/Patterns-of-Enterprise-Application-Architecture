using System;
using System.Windows.Forms;

namespace WindowsFormsApplicationMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public interface ICircleModel
    {
        double getArea(double radius);
    }

    public class CModel : ICircleModel
    {
        public CModel() { }

        public double getArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }

    public interface IView
    {
        string RadiusText { get; set; }
        string ResultText { get; set; }
    }
}
