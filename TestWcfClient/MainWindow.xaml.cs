using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using GalaSoft.MvvmLight.Threading;
using TestWcfClient.ViewModel;

namespace TestWcfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Messenger.Default.Register(this, (PropertyChangedMessage<bool> notificationMessage) =>
            {
                if (notificationMessage.PropertyName != nameof(MainViewModel.FormEnabled))
                    return;

                DispatcherHelper.CheckBeginInvokeOnUI(()=>
                {
                    TextBox.IsEnabled = notificationMessage.NewValue;

                    if (notificationMessage.NewValue)
                    {
                        TextBox.Focus();
                    }
                    else
                        Button.Focus();
                });
            });
        }
    }
}
