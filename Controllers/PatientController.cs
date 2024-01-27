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
    public class PatientController : ControllerBase
    {
        PatientManager cm = new PatientManager(new EfPatient());

        [HttpGet]
        public IActionResult PatientList()
        {
            var values = cm.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PatientAdd(PatientInfo t)
        {
            cm.TAdd(t);
            return Ok();
        }
    }
}
