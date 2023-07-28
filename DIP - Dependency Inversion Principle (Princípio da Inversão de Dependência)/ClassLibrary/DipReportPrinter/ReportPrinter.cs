using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DipReportPrinter
{
    // Classe de alto nível dependendo de uma abstração
    public class ReportPrinter
    {
        private readonly IPrinter _printer;

        public ReportPrinter(IPrinter printer)
        {
            _printer = printer;
        }

        public void PrintReport(string reportContent)
        {
            _printer.Print(reportContent);
        }
    }

    // Interface abstrata
    public interface IPrinter
    {
        void Print(string content);
    }

    // Implementação concreta da interface IPrinter
    public class ConsolePrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing on the console:");
            Console.WriteLine(content);
        }
    }

    // Implementação concreta da interface IPrinter
    public class FilePrinter : IPrinter
    {
        public void Print(string content)
        {
            // Simulação de escrita em arquivo (não implementado)
            Console.WriteLine("Printing to a file:");
            Console.WriteLine(content);
        }
    }

    public class Main
    {
        public Main()
        {
            // Utilização do ReportPrinter com ConsolePrinter
            IPrinter consolePrinter = new ConsolePrinter();
            ReportPrinter reportPrinter = new ReportPrinter(consolePrinter);
            reportPrinter.PrintReport("This is a report for the console.");

            // Utilização do ReportPrinter com FilePrinter
            IPrinter filePrinter = new FilePrinter();
            ReportPrinter reportPrinterWithFile = new ReportPrinter(filePrinter);
            reportPrinterWithFile.PrintReport("This is a report for a file.");
        }

    }
    
}
