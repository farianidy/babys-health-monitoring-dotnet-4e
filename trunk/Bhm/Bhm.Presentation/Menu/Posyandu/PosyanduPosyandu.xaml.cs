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
	/// Interaction logic for PosyanduPosyandu.xaml
	/// </summary>
	public partial class PosyanduPosyandu : UserControl
	{
		UserControl next;
		
		public PosyanduPosyandu()
		{
			this.InitializeComponent();
		}

		private void bBack_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new HomePosyandu();
			Switcher.Switch(next);
		}
	}
}