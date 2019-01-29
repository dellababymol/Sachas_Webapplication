using System;
using System.IO;
using IExceptionLibrary;

namespace ExceptionLibrary
{
    public class FileException : IEx
    {
        public void LogError(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\logfile\log.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString() + "" + ex.Message.ToString());
                sw.Close();
            }
        }
    }
}
