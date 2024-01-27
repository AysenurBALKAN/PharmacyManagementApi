﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PBusinessLayer.Concrete;
using PDataAccessLayer.EntityFramework;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        ReceiptManager cm = new ReceiptManager(new EfReceipt());
        [HttpGet]
        public IActionResult ReceiptList()
        {
            var values = cm.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult ReceiptAdd(Receipt t)
        {
            cm.TAdd(t);
            return Ok();
        }
    }
}
