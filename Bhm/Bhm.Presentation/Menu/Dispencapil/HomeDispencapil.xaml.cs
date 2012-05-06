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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bhm.Presentation
{
	/// <summary>
	/// Interaction logic for HomeDispencapil.xaml
	/// </summary>
	public partial class HomeDispencapil : UserControl
	{
		UserControl next;
		
		public HomeDispencapil()
		{
			this.InitializeComponent();
		}

		private void bDaftarBalita_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new DaftarBalita();
			Switcher.Switch(next);
		}

		private void bLihatBalita_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new LihatBalitaDispen();
			Switcher.Switch(next);
		}

		private void bLogout_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new HomeMain();
			Switcher.Switch(next);
		}
	}
}