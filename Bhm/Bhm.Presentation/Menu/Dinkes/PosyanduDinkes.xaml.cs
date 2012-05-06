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
	public partial class PosyanduDinkes : UserControl
	{
		public PosyanduDinkes()
		{
			this.InitializeComponent();
		}

		private void bCari_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Posyandu p = new Posyandu();

            try
            {
                Posyandu pos = p.FindByName(tbNamaPosyandu.Text, tbKec.Text);
                var next = new DetailPosyanduDinkes();
                next.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak ditemukan", ex.Message, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
		}

		private void bDaftar_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var next = new DaftarPosyandu();
			next.Show();
		}
	}
}