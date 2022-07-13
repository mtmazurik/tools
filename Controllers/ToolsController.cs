using Microsoft.AspNetCore.Mvc;

namespace Tools.Controllers
{
    [ApiController]
    public class ToolsController : Controller
    {
        [Route("/ping")]
        [HttpGet]
        public IActionResult GetPing()
        {
            return Ok();
        }
        [Route("/file")]
        [HttpGet]
        public IActionResult GetFile()
        {
            try
            {
                throw new FileNotFoundException("This is (NYI) not yet implemented.");
            }
            catch (FileNotFoundException exc)
            {
                var stdErr = Console.Error;

                stdErr.WriteLine($"Failed file operation. Inner message : { exc.Message } ");
                return NotFound();
            }
        }
    }


}
