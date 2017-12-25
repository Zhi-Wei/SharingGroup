using System;

namespace TemplateHomework
{
    /// <summary>
    /// 程式。
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主方法。
        /// </summary>
        /// <param name="args">參數集合。</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("========================通知信============================");
            NotifyMail notifyMail = new NotifyMail("通知信", "peterji@gmail.com;");
            notifyMail.SendProcess();

            Console.WriteLine("========================警告信============================");
            ErrorMail errorMail = new ErrorMail("警告信", "peterji@gmail.com;");
            errorMail.SendProcess();

            Console.WriteLine("========================警告信============================");
            ErrorMail errorMail2 = new ErrorMail("警告信", "peterji@gmail.com;", true);
            errorMail2.SendProcess();

            Console.ReadLine();
        }
    }
}