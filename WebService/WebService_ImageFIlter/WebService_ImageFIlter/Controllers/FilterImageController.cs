using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService_ImageFIlter.Models;

namespace WebService_ImageFIlter.Controllers
{
    public class FilterImageController : Controller
    {
        private FilterMethods filterMethods;

        public FilterImageController()
        {
            this.filterMethods = new FilterMethods();
        }

        public JsonResult ApplyFilter(ImageFilterClass imageToFilter)
        {
            switch (Request.HttpMethod)
            {
                case "POST":
                    return Json(filterMethods.applyFilter(imageToFilter));
            }
            return Json(new { Error = true, Message = "Operación HTTP desconocida" });
        }
    }
}