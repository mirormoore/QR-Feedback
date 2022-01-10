using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using QRCoder;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Miro.WebSockets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessionController : Controller
    {

        [HttpGet("Create")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Start")]
        public IActionResult Start(SessionDetails session)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.ricmoore.co.uk/qr/session/join?code=" + session.Code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return File(BitmapToBytes(qrCodeImage), "image/png");
            //return View(BitmapToBytes(qrCodeImage));
        }

        [HttpGet("Join")]
        public IActionResult Join([FromQuery(Name = "code")] string code)
        {
            return View();
        }

        private static Byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

    }

    public class SessionDetails
    {
        public string Code { get; set; }
    }
}
