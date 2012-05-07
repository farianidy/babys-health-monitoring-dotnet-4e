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
	/// <summary>
	/// Interaction logic for LihatLaporan.xaml
	/// </summary>
	public partial class LaporanKeaktifan : Window
	{
		public LaporanKeaktifan()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void bBack_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}
	}
}