

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;
using System.Collections.Generic;

namespace LK2.Controllers
{
    public class ApiController : Controller
    {

      
        [HttpGet]
        public IActionResult Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return Ok(c);
        }
        [HttpGet]
        public IActionResult Subtract()
        {
            int a = 50;
            int b = 20;
            int c = a - b;
            return Ok(c);
        }
        [HttpGet]
        public List<string> GetProcess()
        {
            List<string> alist = new List<string>();
            Process[] localAll = Process.GetProcesses();
            foreach (Process process in localAll)
            {
                alist.Add(process.ProcessName);
            }
            return alist;
        }
        /// <summary>
        /// Provides an endpoint that can be 'pinged' for service monitoring purposes.
        /// </summary>
        /// <returns></returns>
        // GET: /api/v1/ping
      

        /// <summary>
        /// Provides an endpoint that that will generate a short URL.
        /// </summary>
        /// <returns></returns>
        // GET: /api/v1/create
      
    }
}
