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

namespace Com.Zebra.Sdk.Settings.Internal
{
    public abstract partial class ZebraSettingsList
    {
        IDictionary<string, Setting> IZebraSettingsListI.AllSettings
        {
            get
            {
                return AllSettings;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual unsafe void SetAllSettings(global::System.Collections.Generic.IDictionary<string, global::Com.Zebra.Sdk.Settings.Setting> p0)
        {
        }
    }
}