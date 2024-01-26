using Microsoft.AspNetCore.Http;
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
    public class MedicineController : ControllerBase
    {

        MedicineManager cm = new MedicineManager(new EfMedicine());

        [HttpGet]
        public IActionResult MedicineList()
        {
            var values = cm.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult MedicineAdd(MedicineInfo t)
        {
            cm.TAdd(t);
            return Ok();
        }
    }
}
