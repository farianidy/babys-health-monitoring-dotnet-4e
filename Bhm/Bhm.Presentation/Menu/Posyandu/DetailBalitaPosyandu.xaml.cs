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
	/// Interaction logic for DetailBalitaPosyandu.xaml
	/// </summary>
	public partial class DetailBalitaPosyandu : Window
	{
		public DetailBalitaPosyandu()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void bPerbarui_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			this.Close();
		}

		private void bIkutKeg_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var next = new IkutKegiatan();
			next.Show();
		}

		private void bImunisasi_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var next = new Imunisasi();
			next.Show();
		}

		private void bVitamin_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var next = new Vitamin();
			next.Show();
		}

		private void bLihatLaporan_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var next = new LaporanBalitaPosyandu();
			next.Show();
		}
	}
}