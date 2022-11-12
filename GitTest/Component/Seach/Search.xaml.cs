using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CinemaManagementProject.Component.Seach
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public string Text
        {
            get
            {
                return SearchType.Text;
            }
        }
        public event EventHandler SearchTextChange;
        private void SearchType_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchType.Text = "";
        }
        private void SearchType_LostFocus(object sender, RoutedEventArgs e)
        {
            SearchType.Text = "Search";
        }
        protected void SearchType_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextChange != null)
                SearchTextChange(this, e);
        }
    }
}
