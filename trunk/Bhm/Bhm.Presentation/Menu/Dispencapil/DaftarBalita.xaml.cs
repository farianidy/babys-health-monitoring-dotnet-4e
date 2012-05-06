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
	/// Interaction logic for DaftarBalita.xaml
	/// </summary>
	public partial class DaftarBalita : UserControl
	{
		UserControl next;
		
		public DaftarBalita()
		{
			this.InitializeComponent();
		}

		private void bDaftar_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            try
            {
                int anak = Convert.ToInt32(tbAnakKe.Text);
                int bbl = Convert.ToInt32(tbBBL.Text);
                int tbl = Convert.ToInt32(tbTBL.Text);

                next = new HomeDispencapil();
                Switcher.Switch(next);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
		}
	}
}