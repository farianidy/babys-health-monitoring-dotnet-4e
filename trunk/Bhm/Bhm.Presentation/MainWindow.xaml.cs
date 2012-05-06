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

namespace Bhm.Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		UserControl home = new HomeMain();
		
        public MainWindow()
        {
            this.InitializeComponent();
			
			Switcher.pageSwitcher = this;
			Switcher.Switch(home);
        }
		
		public void Navigate(UserControl nextPage)
		{
			this.myUserControl.Content = nextPage;
		}
		
		public void Navigate(UserControl nextPage, object state)
		{
			this.myUserControl.Content = nextPage;
			ISwitchable s = nextPage as ISwitchable;
			
			if(s != null)
				s.UtilizeState(state);
			else
				throw new ArgumentException("nextPage is not ISwitchable! " + nextPage.Name.ToString());
		}
    }
}
