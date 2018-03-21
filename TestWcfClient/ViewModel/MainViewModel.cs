using System;
using System.Windows.Input;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using TestWcfClient.TestServiceReference;

namespace TestWcfClient.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private TestServiceClient _client = new TestServiceClient();

        private DispatcherTimer _timer = new DispatcherTimer();

        private const int WaitBeforeSendInterval = 3;

        public MainViewModel()
        {
            _timer.Interval = TimeSpan.FromSeconds(WaitBeforeSendInterval);
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            SendData();
        }

        private string _data;
        public string Data
        {
            get => _data;
            set
            {
                _timer.Interval = TimeSpan.FromSeconds(WaitBeforeSendInterval);
                Set(ref _data, value, false);
            }
        }

        private bool _formEnabled;
        public bool FormEnabled
        {
            get => _formEnabled;
            set
            {
                Set(ref _formEnabled, value, true);
                if(value)
                    _timer.Start();
                else
                    _timer.Stop();
            }
        }

        private int _num1 = 11;
        public int Num1
        {
            get => _num1;
            set { Set(ref _num1, value, false); }
        }

        private int _num2 = 101;
        public int Num2
        {
            get => _num2;
            set { Set(ref _num2, value, false); }
        }

        private int _num3 = 1001;
        public int Num3
        {
            get => _num3;
            set { Set(ref _num3, value, false); }
        }

        private void SendData()
        {
            FormEnabled = false;
            _client.PutData(Data);
        }

        #region Commands
        private ICommand _requestDataCommand;
        public ICommand RequestDataCommand =>
            _requestDataCommand ?? (_requestDataCommand = new RelayCommand(() =>
            {
                _client.GetDataAsync().ContinueWith(task =>
                {
                    FormEnabled = true;
                    Messenger.Default.Send(true);
                    return Data = task.Result;
                });
            }, () => true));

        private ICommand _getNumCommand1;
        public ICommand GetNumCommand1 =>
            _getNumCommand1 ?? (_getNumCommand1 = new RelayCommand<string>((s =>
                {
                    int value;
                    if (int.TryParse(s, out value))
                    {
                        Num1 = _client.get_num1(value);
                    }
                }),
                s => true));

        private ICommand _getNumCommand2;
        public ICommand GetNumCommand2 =>
            _getNumCommand2 ?? (_getNumCommand2 = new RelayCommand<string>((s =>
                {
                    int value;
                    if (int.TryParse(s, out value))
                    {
                        Num2 = _client.get_num2(value);
                    }
                }),
                s => true));

        private ICommand _getNumCommand3;
        public ICommand GetNumCommand3 =>
            _getNumCommand3 ?? (_getNumCommand3 = new RelayCommand<string>((s =>
                {
                    int value;
                    if (int.TryParse(s, out value))
                    {
                        Num3 = _client.get_num3(value);
                    }
                }),
                s => true));

        private ICommand _sendDataCommand;
        public ICommand SendDataCommand => _sendDataCommand ?? (_sendDataCommand = new RelayCommand(() => SendData(), true));

        #endregion
    }
}