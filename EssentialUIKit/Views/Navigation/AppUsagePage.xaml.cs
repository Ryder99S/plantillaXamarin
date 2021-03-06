using EssentialUIKit.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace EssentialUIKit.Views.Navigation
{
    /// <summary>
    /// Page to display app usage list.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppUsagePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUsagePage" /> class.
        /// </summary>
        public AppUsagePage()
        {
            this.InitializeComponent();
            this.BindingContext = AppUsageDataService.Instance.AppUsageViewModel;
        }
    }
}