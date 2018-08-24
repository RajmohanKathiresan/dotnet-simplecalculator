using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleCalculator.Controllers
{
    [Route("api/[controller]")]
    public class Calculator : Controller
    {
        [Route("add")]
        [HttpGet]
        public int add(int a, int b) 
        {
            return a + b;
        }

        [Route("sub")]
        [HttpGet]
        public int sub(int a, int b)
        {
            return a - b;
        }

        [Route("mul")]
        [HttpGet]
        public int multiply(int a, int b)
        {
            return a * b;
        }

        [Route("div")]
        [HttpGet]
        public float divide(int a, int b)
        {
            return a/b;
        }
    }
}
