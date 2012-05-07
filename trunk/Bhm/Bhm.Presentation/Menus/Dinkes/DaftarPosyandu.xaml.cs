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
	/// Interaction logic for DaftarPosyandu.xaml
	/// </summary>
	public partial class DaftarPosyandu : Window
	{
		public DaftarPosyandu()
		{
			this.InitializeComponent();
		}

		private void bTambah_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var posyandu = new Posyandu
                    {
                        idPosyandu = Int32.Parse(tbIdPosyandu.Text),
                        namaPosyandu = tbNamaPosyandu.Text,
                        desaPosyandu = scbDesa.SelectedValue.ToString(),
                        kecPosyandu = scbKec.SelectedValue.ToString(),
                        kabPosyandu = scbKab.SelectedValue.ToString(),
                        provPosyandu = scbProv.SelectedValue.ToString()
                    };

                    session.Save(posyandu);
                    transaction.Commit();
                }
            }

			this.Close();
		}
	}
}