using Sextant;
using Splat;

namespace SextantSample.ViewModels
{
    public class TabbedViewModel : ViewModelBase
    {
        public HomeViewModel HomeViewModel { get; }

        public TabbedViewModel() : base(Locator.Current.GetService<IViewStackService>())
        {
            HomeViewModel = new HomeViewModel();
        }

    }
}
