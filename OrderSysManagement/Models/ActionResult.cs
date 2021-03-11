using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Models
{
    public class ActionResult
    {
        public ActionStatus Status { get; set; }
        public string Msg { get; set; }
        public IEnumerable<Failed> Faileds { get; set; }
        public ActionResult() { }
        /// <summary>
        /// 单错误信息返回结果
        /// </summary>
        /// <param name="failCode"></param>
        /// <param name="failMsg"></param>
        public ActionResult(string failCode, string failMsg)
        {
            Status = ActionStatus.Failed;
            Faileds = new Failed[]
            {
                new Failed()
                {
                    Code=failCode,
                    Msg=failMsg
                }
            };
        }
    }


    public enum ActionStatus
    {
        OK = 1,
        Failed = 0,
    }
    public class Failed
    {
        public string Code { get; set; }
        public string Msg { get; set; }
    }
}
