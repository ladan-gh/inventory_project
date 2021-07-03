using LadanANDAsma.entity;
using LadanANDAsma.repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadanANDAsma.controller
{
    public class HomePageController : Controller
    {
        
        public readonly ILogger<HomePageController> _logger;
        public readonly CUDanbar a;
        public readonly CUDCustomer c;
        public HomePageController(CUDanbar a, CUDCustomer c, ILogger<HomePageController> _logger)
        {
            this.a = a;
             this.c = c;
            this._logger = _logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("you are in Index action!");
            return Ok("wellcome");
        }
        [HttpPost]
        public IActionResult LogInCustomer([FromBody] Customer customer)
        {
            _logger.LogInformation("you are in LogInAdmin!!");
            if (ModelState.IsValid)
            {
                return View(c.CreateCustomer(customer));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
        [HttpPost]
        public IActionResult LogInAbar([FromBody] anbar anbar)
        {
            _logger.LogInformation("you are in LogInAdmin!!");
            if (ModelState.IsValid)
            {
                return View(a.CreateAnbar(anbar));
            }
            else
            {
                _logger.LogInformation("your inputs is'nt valid !!");
                _logger.LogError("bad model");
                return BadRequest("your identity is not valid!");

            }
        }
    }
}
