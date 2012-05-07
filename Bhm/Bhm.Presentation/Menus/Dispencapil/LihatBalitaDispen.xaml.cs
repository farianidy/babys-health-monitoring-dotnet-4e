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
	/// Interaction logic for LihatBalitaDispen.xaml
	/// </summary>
	public partial class LihatBalitaDispen : UserControl
	{
		UserControl next;
		
		public LihatBalitaDispen()
		{
			this.InitializeComponent();
		}

		private void bBack_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new HomeDispencapil();
			Switcher.Switch(next);
		}
	}
}