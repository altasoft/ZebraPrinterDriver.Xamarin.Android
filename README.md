# ZebraPrinterDriver.Xamarin.Android
Zebra Printer Driver ported for Xamarin.Android. With live sample.


Sample:
```c#
var devices = BluetoothAdapter.DefaultAdapter.BondedDevices;
var device = devices.FirstOrDefault();
var macAddress = device.Address;

using (var printerCo = new BluetoothPrinterConnection(macAddress))
{
  printerCo.Open();

  var scaledHeight = bitmap.Height * scaledWidth / bitmap.Width;

  using (var zbr = ZebraPrinterFactory.GetInstance(PrinterLanguage.Cpcl, printerCo))
  {
    zbr.ToolsUtil.SendCommand("! U1 JOURNAL\r\n! U1 SETFF 50 2\r\n"); //For skip empty feed after printing image
    zbr.GraphicsUtil.PrintImage(bitmap, 0, 0, scaledWidth, scaledHeight, false);
  }

  printerCo.Close();
}
```
