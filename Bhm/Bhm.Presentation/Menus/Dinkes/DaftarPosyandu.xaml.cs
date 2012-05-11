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
            string a =  scbDesa.SelectedValue.ToString();
            string b = scbKec.SelectedValue.ToString();
            string c = scbKab.SelectedValue.ToString();
            string d = scbProv.SelectedValue.ToString();

            a = a.Substring(37, a.Length - 37);
            b = b.Substring(37, b.Length - 37);
            c = c.Substring(37, c.Length - 37);
            d = d.Substring(37, d.Length - 37);

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var posyandu = new Posyandu
                    {
                        //idPosyandu = Int32.Parse(tbIdPosyandu.Text),
                        namaPosyandu = tbNamaPosyandu.Text,
                        desaPosyandu = a,
                        kecPosyandu = b,
                        kabPosyandu = c,
                        provPosyandu = d

                        //namaPosyandu = "Sehat Selalu",
                        //desaPosyandu = "Tambak Rejo",
                        //kecPosyandu = "Sedati",
                        //kabPosyandu = "Sidoarjo",
                        //provPosyandu = "Jawa Timur"
                    };

                    session.Save(posyandu);
                    transaction.Commit();
                }
            }

			this.Close();
		}
	}
}