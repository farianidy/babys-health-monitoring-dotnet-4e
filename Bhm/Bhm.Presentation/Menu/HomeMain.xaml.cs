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
	/// Interaction logic for HomeMain.xaml
	/// </summary>
	public partial class HomeMain : UserControl
	{
		UserControl next;
		BaseFunc bf = new BaseFunc();
		
		public HomeMain()
		{
			this.InitializeComponent();
		}

		private void bCari_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			next = new HasilCariPage();
			Switcher.Switch(next);
		}

		private void bLogin_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			if (tbUsername.Text.Length == 0 || pbPassword.Password.Length == 0)
                bf.isEmpty();
            else
            {
                int result = bf.login(tbUsername.Text, pbPassword.Password);

                if (result == -2)
                    MessageBox.Show("Maaf, ID anda tidak valid.", "Informasi", MessageBoxButton.OK, MessageBoxImage.Information);
                else if (result == -1)
                    MessageBox.Show("Password yang anda masukkan salah.", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Warning);
                else
                {
                    if (result == 0)
                    {
                        next = new HomeDispencapil();
                        Switcher.Switch(next);
                    }
                    else if (result == 1)
                    {
                        next = new HomePosyandu();
                        Switcher.Switch(next);
                    }
                    else if (result == 2)
                    {
                        next = new HomeDinkes();
                        Switcher.Switch(next);
                    }
                }
            }
		}
	}
}