using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Zebra.Sdk.Comm;

namespace Com.Zebra.Sdk.Printer.Internal
{
    public abstract partial class ZebraPrinterA
    {
        IConnection IZebraPrinter.Connection
        {
            get
            {
                return Connection;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual unsafe void SetConnection(global::Com.Zebra.Sdk.Comm.IConnection p0)
        {

        }
    }
}