
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text; 
using System;

//cordova.exec(win, fail, "com.abbypan.gb2312.GetUrl", ...);
//System.Text.Encoding ENC_UTF8 = System.Text.Encoding.UTF8;  
//MSG = GB2312.GetString (UTF8.GetByte)   (STR));
//MSG = UTF9.GetString (GB2312.GetByte (STR)));
namespace com.abbypan.urlcn {
    public class RequestUrlCN : BaseCommand
    {
        public string GetUrl(string url){
            System.Text.Encoding ENC_GB2312 = System.Text.Encoding.GetEncoding ("GB2312");
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(
                    myResponse.GetResponseStream(), 
                    ENC_GB2312);
            string data = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();
            return data;
        }
    }
}
