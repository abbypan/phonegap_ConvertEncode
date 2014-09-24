using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

using System;
using System.IO;
using System.Text; 

namespace ConvertEncode
{

    public class ConvertEncode : BaseCommand
    {
        public string from_to(string src, string f, string t)
        {            
            Encoding fenc = Encoding.GetEncoding(f);
            Encoding tenc = Encoding.GetEncoding(t);

            byte[] fBytes = fenc.GetBytes(src);
            byte[] tBytes = Encoding.Convert(fenc, tenc, fBytes);

            string dst = tenc.GetString(tBytes);
            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, dst));
            }
        }
}
