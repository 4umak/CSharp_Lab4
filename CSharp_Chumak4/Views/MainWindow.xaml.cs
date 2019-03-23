using System.Windows;

namespace CSharp_Chumak4.Views
{ 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new UserListViewModel(delegate () { Dispatcher.Invoke(UsersDataGrid.Items.Refresh); });
        }

        
    }
}
