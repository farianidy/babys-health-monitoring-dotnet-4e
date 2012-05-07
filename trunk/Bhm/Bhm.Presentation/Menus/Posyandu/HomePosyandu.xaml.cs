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
	/// Interaction logic for HomePosyandu.xaml
	/// </summary>
	public partial class HomePosyandu : UserControl
	{
		UserControl next;
		
		public HomePosyandu()
		{
			this.InitializeComponent();
		}

		private void bBalita_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new BalitaPosyandu();
			Switcher.Switch(next);
		}

		private void bPosyandu_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new PosyanduPosyandu();
			Switcher.Switch(next);
		}

		private void bLogout_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new HomeMain();
			Switcher.Switch(next);
		}
	}
}