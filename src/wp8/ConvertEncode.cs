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
        public void from_to(string src, string f, string t)
        {            
            Encoding fenc = Encoding.GetEncoding(f);
            Encoding tenc = Encoding.GetEncoding(t);

            byte[] fBytes = fenc.GetBytes(src);
            byte[] tBytes = Encoding.Convert(fenc, tenc, fBytes);

            string dst = tenc.GetString(tBytes, 0, tBytes.Length);
            this.DispatchCommandResult(new PluginResult(PluginResult.Status.OK, dst));
            }
        }
}
