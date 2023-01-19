using Microsoft.Maui.Devices;
using System.Text;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		LoadInfo();
    }

	private void LoadInfo()
	{
		var device = DeviceInfo.Current;
		var sb = new StringBuilder();

		sb.AppendLine($"Brand: {device.Manufacturer}");
		sb.AppendLine($"Model: {device.Model}");
		sb.AppendLine($"Idiom: {device.Idiom}");
		sb.AppendLine($"Name: {device.Name}");
		sb.AppendLine($"Device Type: {device.DeviceType.ToString()}");
		sb.AppendLine($"Platform: {device.Platform}");
		sb.AppendLine($"Version: {device.Version}");
		sb.AppendLine($"Version string: {device.VersionString}");

        phoneInfoLbl.Text = sb.ToString();
    }
}
