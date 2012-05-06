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
using Bhm.Model;

namespace Bhm.Presentation
{
	/// <summary>
	/// Interaction logic for BalitaPosyandu.xaml
	/// </summary>
	public partial class BalitaPosyandu : UserControl
	{
		public BalitaPosyandu()
		{
			this.InitializeComponent();
		}

		private void bCari_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Balita b = new Balita();

            try
            {
                Balita balita = b.FindByName(tbNamaBalita.Text, tbNamaAyah.Text, tbNamaIbu.Text);
                var next = new DetailBalitaPosyandu();
                next.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak ditemukan", ex.Message, MessageBoxButton.OK, MessageBoxImage.Warning);
            }

		}
	}
}