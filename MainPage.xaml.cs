using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TestApp1
{
	public sealed partial class MainPage : Page
	{

		public MainPage()
		{
			this.InitializeComponent();

			ListBox_JavaPath.Items.Clear();
			Dictionary<string,string> JavaPaths = Launcher.Environment.JavaManager.GetJavaPaths();
			if (JavaPaths != null)
			{
				foreach (var path in JavaPaths)
				{
					ListBox_JavaPath.Items.Add($"{path.Key} {path.Value}");
				}
			}
			
		}

		private void Button_Launch_Click(object sender, RoutedEventArgs e)
		{

			
		}
	}
}
