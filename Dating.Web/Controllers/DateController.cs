using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating.BusinessLayer.Interface;
using Dating.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dating.Web.Controllers
{
    public class DateController : Controller
    {
        private readonly IDateService _dateService;
        public DateController(IDateService dateService)
        {
            _dateService = dateService;

        }

        /// <summary>
        /// Send date invitation via mail
        /// </summary>
        /// <returns></returns>
        public IActionResult SendRequest()
        {
            //Business logic goes here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Send date invitation via mail
        /// </summary>
        /// <param name="dateDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SendRequest(DateDetails dateDetails)
        {
            //Business logic goes here
            throw new NotImplementedException();
        }
    }
}