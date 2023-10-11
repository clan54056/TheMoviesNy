using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace TheMovies.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextbox.xaml
    /// </summary>
    public partial class ClearableTextbox : UserControl, INotifyPropertyChanged
    {
        public ClearableTextbox()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string placeholder;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;

                // do not do this..!
                //tbPlaceholder.Text = placeholder;

                //DO THIS - OnPropertyChanged
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Placeholder)); // made the method beneith "OnPropertyChanged insted to automatically operate OnPropertyChanged
                OnPropertyChanged();
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else
                tbPlaceholder.Visibility = Visibility.Hidden;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyNmae = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyNmae));
        }
    }
}
