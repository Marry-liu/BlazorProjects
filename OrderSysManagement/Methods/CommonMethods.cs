using AntDesign;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OrderSysManagement.Methods
{
    public class CommonMethods
    {
        public ModalService ModalService { get; set; }
        public CommonMethods(ModalService modalService)
        {
            this.ModalService = modalService;
        }
        
        public DateTime SetParameters(string para)
        {
            return Convert.ToDateTime(WebUtility.UrlDecode(para));
        }
        public void HandleInfo(string content)
        {
            ModalService.Info(new ConfirmOptions()
            {
                Title = "提示：",
                Content = content
            });
        }
        public void HandleSuccess(string content)
        {
            ModalService.Success(new ConfirmOptions()
            {
                Title = "成功：",
                Content = content
            });
        }
        public void HandleError(string content)
        {
            ModalService.Error(new ConfirmOptions()
            {
                Title = "错误：",
                Content = content
            });
        }
        public void HandleWarning(string content)
        {
            ModalService.Warning(new ConfirmOptions()
            {
                Title = "警告：",
                Content = content
            });
        }
    }
}
