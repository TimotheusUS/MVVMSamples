using System.Windows.Input;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.RelativeSource
{
    public class ViewModelTemplatedParentMode : ViewModelBase
    {
        private string ping = "Click me ping";
        private string pong = "Click me pong";
        private ICommand allertPongCommand;
        private ICommand allertPingCommand;

        public ViewModelTemplatedParentMode()
        {
            allertPongCommand = new RelayCommand(this.AllertPong);
            allertPingCommand = new RelayCommand(this.AllertPing);
        }
        public ICommand AllertPongCommand
        {
            get => this.allertPongCommand;
        }
        public ICommand AllertPingCommand
        {
            get => this.allertPingCommand;
        }
        public string Ping
        {
            get => this.ping;
            set
            {
                this.ping = value;
                OnPropertyChanged(nameof(this.Ping));
            }
        }
        public string Pong
        {
            get => this.pong;
            set
            {
                this.pong = value;
                OnPropertyChanged(nameof(this.Pong));
            }
        }
        private void AllertPong()
        {
            Ping = nameof(this.Ping);
        }
        private void AllertPing()
        {
            Pong = nameof(this.Pong);
        }
    }
}
