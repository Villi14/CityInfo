using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _extensionContentTypeProvider;

        public FilesController(FileExtensionContentTypeProvider extensionContentTypeProvider)
        {
            _extensionContentTypeProvider = extensionContentTypeProvider ?? throw new System.ArgumentNullException(nameof(extensionContentTypeProvider));
        }

        // Use a route parameter so endpoint is: GET /api/files/{fileId}
        [HttpGet("{fileId}")]
        public IActionResult GetFiles(string fileId)
        {
            var pathToFile = "getting-started-with-rest-slides.pdf";

            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            if (!_extensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var fileBytes = System.IO.File.ReadAllBytes(pathToFile);
            // return correct content type for PDF and ensure Path is resolved
            return File(fileBytes, contentType, Path.GetFileName(pathToFile));
        }
    }
}
