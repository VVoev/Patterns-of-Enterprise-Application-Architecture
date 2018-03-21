using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Startup
    {
        static void Main(string[] args)
        {
            FirstDemo();
            SecondDemo();
        }

        private static void SecondDemo()
        {
            DataExporter exporter = null;

            // Lets export the data to Excel file
            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            // Lets export the data to PDF file
            exporter = new PDFExporter();
            exporter.ExportFormatedData();
        }

        private static void FirstDemo()
        {
            AbstractAlgorithmSkeleton objTemplate = null;
            objTemplate = new ConcreteClassA();
            // Now this call to TemplateMethod() will direct calls
            // to methods in ConcreteClassA.
            objTemplate.TemplateMethod();
        }
    }
    
    abstract class DataExporter
    {
        // This will not vary as the data is read from sql only
        public void ReadData()
        {
            Console.WriteLine("Reading the data from SqlServer");
        }

        // This will not vary as the format of report is fixed.
        public void FormatData()
        {
            Console.WriteLine("Formating the data as per requriements.");
        }

        // This may vary based on target file type choosen
        public abstract void ExportData();

        // This is the template method that the client will use.
        public void ExportFormatedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData();
        }
    }
    class ExcelExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to an Excel file.");
        }
    }
    class PDFExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a PDF file.");
        }
    }
}

#region FirstDemo
public abstract class AbstractAlgorithmSkeleton
{
    public void TemplateMethod()
    {
        // Template Method declaring algorithm
        // in terms of abstract operations.
        Step1();
        Step2();
        Step3();
    }
    public abstract void Step1();
    public abstract void Step2();
    public abstract void Step3();
}

public class ConcreteClassA : AbstractAlgorithmSkeleton
{
    public override void Step1()
    {
        Console.WriteLine("ConcreteClassA, Step 1");
    }

    public override void Step2()
    {
        Console.WriteLine("ConcreteClassA, Step 2");
    }

    public override void Step3()
    {
        Console.WriteLine("ConcreteClassA, Step 3");
    }

    public void OtherMethodA()
    {
        //
    }
}

public class ConcreteClassB : AbstractAlgorithmSkeleton
{
    public override void Step1()
    {
        Console.WriteLine("ConcreteClassB, Step 1");
    }

    public override void Step2()
    {
        Console.WriteLine("ConcreteClassB, Step 2");
    }

    public override void Step3()
    {
        Console.WriteLine("ConcreteClassB, Step 3");
    }

    public void OtherMethodB()
    {
        //
    }
    #endregion
}

