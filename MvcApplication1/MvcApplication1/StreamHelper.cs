using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace MvcApplication1
{
    public class StreamHelper
    {
        public Stream GetStreamFromUrl(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            return responseStream;
        }
    }
}