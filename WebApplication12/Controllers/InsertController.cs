using Microsoft.AspNetCore.Mvc.ActionConstraints;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.BAL;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;

namespace WebApplication12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class InsertController : ControllerBase
    {
        private readonly Insert? _insert;
        private readonly MyDbContext _context;
        public InsertController(Insert? insert, MyDbContext context)
        {
            _insert = insert;
            _context = context;
        }
        [HttpPost("ImportFromExcel")]
        public async Task<IActionResult> ImportFromExcel(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var users1 = await _insert.ParseExcelFile1(file.OpenReadStream());
                var users2 =await _insert.ParseExcelFile2(file.OpenReadStream());
                await _context.SaveChangesAsync();
                return Ok("UploadSuccess");
            }
            return Ok("failed");

        }
        [HttpPost("ImportFromExcel2")]
        public async Task<IActionResult> ImportFromExcelFile2(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                //await _insert.ParseExcelFile3(file.OpenReadStream());
                await _insert.MapDepartmentAndCategory(file.OpenReadStream());
                return Ok("UploadSucess");
            }
            return Ok("failed");
        }
    }
}


