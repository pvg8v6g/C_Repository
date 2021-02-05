using System;
using System.IO;

namespace CefSharpTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                WriteToTextFile("log.txt", e.ToString());
            }
        }

        public static void WriteToTextFile(string file, object text)
        {
            var toToAdd = text?.ToString() ?? "null";
            var docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "C Projects");
            var internalPath = Path.Combine(docPath, file);
            File.AppendAllText(internalPath, toToAdd);
        }
    }
}
