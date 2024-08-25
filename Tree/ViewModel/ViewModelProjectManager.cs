using System.Collections.ObjectModel;
using TimotheusUS.MVVMsamples.Utilities;

namespace TimotheusUS.MVVMsamples.Tree
{
    public class ViewModelProjectManager : ViewModelBase
    {
        public string Header
        {
            get => "test1";
        }
        public ObservableCollection<ViewModelProject> Projects
        {
            get => this.GetProjects();
        }
        private ObservableCollection<ViewModelProject> GetProjects()
        {
            ViewModelRequrirement requrirement1 = new ViewModelRequrirement() { Name = nameof(requrirement1) };
            ViewModelRequrirement requrirement2 = new ViewModelRequrirement() { Name = nameof(requrirement2) };
            ViewModelRequrirement requrirement3 = new ViewModelRequrirement() { Name = nameof(requrirement3) };
            ViewModelProject project1 = new ViewModelProject()
            {
                Name = nameof(project1),
                Requrirements = new ObservableCollection<ViewModelRequrirement>() { requrirement1 }
            };
            ViewModelProject project2 = new ViewModelProject()
            {
                Name = nameof(project2),
                Requrirements = new ObservableCollection<ViewModelRequrirement>() { requrirement2, requrirement3 }
            };
            return new ObservableCollection<ViewModelProject>() { project1, project2 } ;
        }
    }
}