using System;

namespace TemplateHomework
{
    /// <summary>
    /// 錯誤通知信件。
    /// </summary>
    /// <seealso cref="TemplateHomework.Mail" />
    public class ErrorMail : Mail
    {
        /// <summary>
        /// 內容。
        /// </summary>
        private string _body;

        /// <summary>
        /// 初始化 <see cref="ErrorMail"/> 類別新的執行個體。
        /// </summary>
        /// <param name="title">標題。</param>
        /// <param name="receiver">收件者。</param>
        /// <param name="isNoticeSupervisor">是否通知管理者，是為 <c>true</c> 否則為 <c>false</c>。</param>
        public ErrorMail(string title, string receiver, bool isNoticeSupervisor = false)
            : base(title, receiver, isNoticeSupervisor)
        {
        }

        /// <summary>
        /// 製作信件內容。
        /// </summary>
        protected override void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "這是一封警告信";
            Console.WriteLine("信件內容:" + this._body);
        }
    }
}