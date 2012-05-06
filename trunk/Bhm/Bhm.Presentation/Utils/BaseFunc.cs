using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace Bhm.Presentation
{
	public class BaseFunc
	{
		public BaseFunc()
		{
		}

        public int login(string username, string password)
        {
            string id = username;

            if (id.StartsWith("dis"))
            {
                return 0;
            }
            else if (id.StartsWith("kad"))
            {
                return 1;
            }
            else if (id.StartsWith("din"))
            {
                return 2;
            }
            return -2;      // ID tidak ada
        }

        /*public string generateID(string prefix, string table, int idxCol, int length)
        {
            connect.Open();

            int count = 1;
            string sql = "SELECT * FROM " + table;
            OracleDataReader reader = connect.ExecuteReader(sql);
            List<int> index = new List<int>();

            while (reader.Read())
            {
                index.Add(int.Parse(reader.GetString(idxCol).Substring(prefix.Length, length).Trim()));
            }

            index.Sort();
            for (int i = 1; i <= index.Count; i++)
            {
                if (index[i - 1] != i)
                {
                    count = 1;
                    break;
                }
                count++;
            }

            connect.Close();

            if (length == 4)
            {
                if (count < 10)
                    return prefix + "000" + count;
                else if (count < 100)
                    return prefix + "00" + count;
                else if (count < 1000)
                    return prefix + "0" + count;
                else
                    return prefix + count;
            }
            else
            {
                if (count < 10)
                    return prefix + "00" + count;
                else if (count < 100)
                    return prefix + "0" + count;
                else
                    return prefix + count;
            }
        }*/

        public void isEmpty()
        {
            MessageBox.Show("Data belum terisi", "Peringatan", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void addComboboxItem(ComboBox cb, DataTable data, int idx)
        {
            clearComboboxItem(cb);

            if (data != null)
                for (int i = 0; i < data.Rows.Count; i++)
                    cb.Items.Add(data.Rows[i][idx].ToString());
        }

        public void clearComboboxItem(ComboBox cb)
        {
            for (int i = cb.Items.Count - 1; i >= 0; i--)
                cb.Items.RemoveAt(i);
        }
	}
}