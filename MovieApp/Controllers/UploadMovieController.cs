using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UploadMovieController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> UploadMovies(IFormFile files)
        {
            if (!System.IO.Directory.Exists(@"C:\Temp"))
            {
                System.IO.Directory.CreateDirectory(@"C:\Temp");
            }
            var filePath = @"C:\Temp\" + DateTime.Now.ToString("MMddyyyy_hhmmss") + files.FileName;

            using (var stream = System.IO.File.Create(filePath))
            {
                await files.CopyToAsync(stream);
            }

            // Process uploaded files

            return Ok();

        }
    }
}