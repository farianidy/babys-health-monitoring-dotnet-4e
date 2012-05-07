using System;
using System.Collections.Generic;
using System.Linq;
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

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate;
using FluentNHibernate.Mapping;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool;
using NHibernate.Linq;

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
            LoadDataGrid();
		}

        private void LoadDataGrid()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var posyandus = session.Query<Posyandu>()
                        .OrderBy(b => b.namaPosyandu)
                        .ToList();
                dgPosyandu.ItemsSource = posyandus;
                dgPosyandu.DisplayMemberPath = "Nama";
            }
        }

		private void bCari_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Posyandu p = new Posyandu();

            try
            {
                //Posyandu pos = p.FindByName(tbNamaPosyandu.Text, tbKec.Text);
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