using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateHomework
{
    /// <summary>
    /// 信件抽象類別。
    /// </summary>
    public abstract class Mail
    {
        /// <summary>
        /// 標題。
        /// </summary>
        private string _title;

        /// <summary>
        /// 收件者。
        /// </summary>
        private string _receiver;

        /// <summary>
        /// 是否通知管理者。
        /// </summary>
        private bool _isNoticeSupervisor;

        /// <summary>
        /// 初始化 <see cref="Mail" /> 類別新的執行個體。
        /// </summary>
        /// <param name="title">標題。</param>
        /// <param name="receiver">收件者。</param>
        /// <param name="isNoticeSupervisor">是否通知管理者，是為 <c>true</c> 否則為 <c>false</c>。</param>
        /// <exception cref="ArgumentException"></exception>
        public Mail(string title, string receiver, bool isNoticeSupervisor = false)
        {
            var paramsChecklist = new Dictionary<string, Func<bool>>
            {
                { nameof(title), () => string.IsNullOrWhiteSpace(title) },
                { nameof(receiver), () => string.IsNullOrWhiteSpace(receiver) }
            };

            var paramName = paramsChecklist.FirstOrDefault(x => x.Value() == true).Key;

            if (string.IsNullOrWhiteSpace(paramName) == false)
            {
                throw new ArgumentException(paramName);
            }

            this._title = title;
            this._receiver = receiver;
            this._isNoticeSupervisor = isNoticeSupervisor;
        }

        /// <summary>
        /// 製作信件標題。
        /// </summary>
        private void MakeMailTitle()
        {
            Console.WriteLine("標題:" + _title);
        }

        /// <summary>
        /// 製作信件收件者。
        /// </summary>
        private void MakeMailReceiver()
        {
            Console.WriteLine("收件人:" + _receiver);
        }

        /// <summary>
        /// 增加管理者為信件收件者。
        /// </summary>
        private void AddReceiverSupervisor()
        {
            this._receiver += "xxx@gmail.com;";
            Console.WriteLine("收件人:" + _receiver);
        }

        /// <summary>
        /// 發送信件。
        /// </summary>
        private void Send()
        {
            Console.WriteLine("寄信完成");
        }

        /// <summary>
        /// 製作信件內容。
        /// </summary>
        protected abstract void MakeMailBody();

        /// <summary>
        /// 發送信件處理程序。
        /// </summary>
        public void SendProcess()
        {
            this.MakeMailTitle();
            this.MakeMailReceiver();

            if (this._isNoticeSupervisor)
            {
                this.AddReceiverSupervisor();
            }

            this.MakeMailBody();
            this.Send();
        }
    }
}