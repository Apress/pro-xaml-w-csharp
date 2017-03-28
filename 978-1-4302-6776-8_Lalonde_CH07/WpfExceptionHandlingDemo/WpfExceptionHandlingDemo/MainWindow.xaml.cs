using System;
using System.IO;
using System.Windows;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace WpfLoggingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileStream fs;

        private ExceptionManager exceptionManager;
        private void InitializeExceptionManager()
        {
            //LogWriterFactory logWriterFactory = new LogWriterFactory();
            //Logger.SetLogWriter(logWriterFactory.Create());

            ExceptionPolicyFactory exceptionFactory = new ExceptionPolicyFactory();
            exceptionManager = exceptionFactory.CreateManager();
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeExceptionManager();
        }

private void FileNotFoundExceptionButton_Click(object sender, RoutedEventArgs e)
{
    try
    {
        OpenFile("myfakefile.txt");
    }
    catch (Exception ex)
    {
        //the original exception should be wrapped
        HandleMyException("FileNotFoundExceptionButton_Click", ex);
    }
}

private void NullReferenceExceptionButton_Click(object sender, RoutedEventArgs e)
{
    try
    {
        int fileByte = GetFileByte();
        MessageBox.Show(fileByte.ToString());
    }
    catch (Exception ex)
    {
        //the original exception should be replaced
        HandleMyException("NullReferenceExceptionButton_Click", ex);
    }
}

private void HandleMyException(string exceptionPrefix, Exception ex)
{
    string exceptionDetails = string.Format("{0} Exception: {1} {2}",
        exceptionPrefix,
        ex.Message,
        System.Environment.NewLine);

    if (ex.InnerException != null)
    {
        exceptionDetails += string.Format("{0} Inner Exception: {1} {2}",
            exceptionPrefix,
            ex.InnerException.Message,
            System.Environment.NewLine);

    }

    ExceptionOutputTextBox.Text += exceptionDetails;
}

private void OpenFile(string fileName)
{
    exceptionManager.Process(() => fs = File.Open(fileName, FileMode.Open, FileAccess.Read), "FilePolicy");
}

private int GetFileByte()
{
    int fileByte = 0;
    exceptionManager.Process(() => fileByte = fs.ReadByte(), "FilePolicy");
    return fileByte;
}
    }
}
