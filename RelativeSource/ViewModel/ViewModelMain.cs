using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.RelativeSource
{
    public class ViewModelMain : ViewModelBase
    {
        private ViewModelSelfMode viewModelSelfMode1 = new ViewModelSelfMode();
        private ViewModelFindAncestorMode viewModelFindAncestorMode1 = new ViewModelFindAncestorMode();
        private ViewModelPreviousData viewModelPreviousData = new ViewModelPreviousData();
        private ViewModelTemplatedParentMode viewModelTemplatedParentMode1 = new ViewModelTemplatedParentMode();
        public ViewModelMain()
        {
            this.viewModelPreviousData.Items.Add(new ViewModelItem() { Value = 101.0 });
            this.viewModelPreviousData.Items.Add(new ViewModelItem() { Value = 120.1 });
            this.viewModelPreviousData.Items.Add(new ViewModelItem() { Value = 61.2 });
            this.viewModelPreviousData.Items.Add(new ViewModelItem() { Value = 50.5 });
            this.viewModelPreviousData.Items.Add(new ViewModelItem() { Value = 72.6 });
        }
        public ViewModelSelfMode ViewModelSelfMode1
        {
            get => this.viewModelSelfMode1;
            set
            {
                this.viewModelSelfMode1 = value;
                OnPropertyChanged(nameof(this.ViewModelSelfMode1));
            }
        }
        public ViewModelFindAncestorMode ViewModelFindAncestorMode1
        {
            get => this.viewModelFindAncestorMode1; 
            set
            {
                this.viewModelFindAncestorMode1 = value;
                OnPropertyChanged(nameof(this.ViewModelFindAncestorMode1));
            }
        }
        public ViewModelPreviousData ViewModelPreviousData
        {
            get => this.viewModelPreviousData;
            set
            {
                this.viewModelPreviousData = value;
                OnPropertyChanged(nameof(this.ViewModelPreviousData));
            }
        }
        public ViewModelTemplatedParentMode ViewModelTemplatedParentMode1
        {
            get => this.viewModelTemplatedParentMode1;
            set
            {
                this.viewModelTemplatedParentMode1 = value;
                OnPropertyChanged(nameof(this.ViewModelTemplatedParentMode1));
            }
        }
    }
}
