using App.Core.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebInfo.MVCUI.Controllers
{
    public class ControllerBase:Controller
    {
        public AlertUi alertUi { get; set; }
        public ControllerBase()
        {
            alertUi = new AlertUi();
        }

        public void AlertUiMessage()
        {
            TempData["alertUi"] = alertUi.ToString();
        }
    }
}
