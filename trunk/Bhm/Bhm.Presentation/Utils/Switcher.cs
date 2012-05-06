using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bhm.Presentation
{
	public static class Switcher
	{
		public static MainWindow pageSwitcher;
	
		public static void Switch(UserControl newPage)
		{
			pageSwitcher.Navigate(newPage);
		}
	
		public static void Switch(UserControl newPage, object state)
		{
			pageSwitcher.Navigate(newPage, state);
		}
	}
}