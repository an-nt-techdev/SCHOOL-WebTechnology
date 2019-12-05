using Newtonsoft.Json;
using QuanLyBanHang.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyBanHang.Controllers
{
    public class CommandBaseController : Controller
    {
        protected static Object Success(List<dynamic> data, string message = null)
        {
            return new
            {
                Data = data,
                IsSuccess = true,
                Message = message ?? "success"
            };
        }
        protected ActionResult JsonExpando(object obj)
        {
            return Content(JsonConvert.SerializeObject(obj), "application/json");
        }
        protected dynamic Success(bool b, string Mes = "Thành công!")
        {
            return new
            {
                IsSuccess = b,
                Message = Mes
            };
        }
        public CommandBaseController()
        {
            NotificationListAction cmd = new NotificationListAction();
            ViewBag.Notification = cmd.Execute();
         
        }
        [HttpPost]
        public ActionResult NotificationExecuteSave(NotificationExecuteSaveAction CommandAction)
        {
            try
            {
                return JsonExpando(Success(CommandAction.Execute()));
            }
            catch (Exception ex)
            {
                return JsonExpando(Success(false, ex.Message));
            }
        }
    }
}