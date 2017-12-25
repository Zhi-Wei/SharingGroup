using System;

namespace TemplateHomework
{
    /// <summary>
    /// 通知信件。
    /// </summary>
    /// <seealso cref="TemplateHomework.Mail" />
    public class NotifyMail : Mail
    {
        /// <summary>
        /// 內容。
        /// </summary>
        private string _body;

        /// <summary>
        /// 初始化 <see cref="NotifyMail"/> 類別新的執行個體。
        /// </summary>
        /// <param name="title">標題。</param>
        /// <param name="receiver">收件者。</param>
        public NotifyMail(string title, string receiver)
            : base(title, receiver)
        {
        }

        /// <summary>
        /// 製作信件內容。
        /// </summary>
        protected override void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "這是一封通知信";
            Console.WriteLine("信件內容:" + this._body);
        }
    }
}