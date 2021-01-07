using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task5___Talents_Photo.Controllers
{
    public class HomeController : Controller
    {
        private const string keyName = "updatedtestfile.jpg";
        private const string filePath = null;
        // Specify your bucket region (an example region is shown).  
        private static readonly string bucketName = "csc-talentsphoto";
        private static readonly RegionEndpoint bucketRegion = RegionEndpoint.USEast1;
        private static readonly string accesskey = "ASIA2RHETZF3E75AZH6Q";
        private static readonly string secretkey = "lR8CaFe/MzAbUNh4IpIwJyhnqu3mKtqLRgAzqqbL";

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult UploadToS3()
        {
            return View();
        }
        
    }
}
