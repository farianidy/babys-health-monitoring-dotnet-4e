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
	/// Interaction logic for HomeDinkes.xaml
	/// </summary>
	public partial class HomeDinkes : UserControl
	{
		UserControl next;
		
		public HomeDinkes()
		{
			this.InitializeComponent();
		}

		private void bBalita_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new BalitaDinkes();
			Switcher.Switch(next);
		}

		private void bPosyandu_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new PosyanduDinkes();
			Switcher.Switch(next);
		}

		private void bLaporanGizi_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var newWin = new LaporanGizi();
			newWin.Show();
		}

		private void bLaporanKeaktifan_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var newWin = new LaporanKeaktifan();
			newWin.Show();
		}

		private void bLogout_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new HomeMain();
			Switcher.Switch(next);
		}
	}
}