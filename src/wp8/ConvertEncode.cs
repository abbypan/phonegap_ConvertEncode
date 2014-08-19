using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

using System.IO;
using System.Text; 
using System;

namespace WPCordovaClassLib.Cordova.Commands
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
