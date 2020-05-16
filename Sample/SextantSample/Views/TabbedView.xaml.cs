using ReactiveUI.XamForms;
using SextantSample.ViewModels;

namespace SextantSample.Views
{
    public partial class TabbedView : ReactiveTabbedPage<TabbedViewModel>
    {
        public TabbedView()
        {
            InitializeComponent();
            ViewModel = new TabbedViewModel();
            tab1View.ViewModel = ViewModel.HomeViewModel;
            tab2View.ViewModel = ViewModel.HomeViewModel;
        }
    }
}
