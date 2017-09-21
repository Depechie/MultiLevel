using MultiLevelGrouping.ViewModels;
using Xamarin.Forms;

namespace MultiLevelGrouping.Views
{
    public partial class MultiLevelGroupingPage : ContentPage
    {
        public MultiLevelGroupingPage()
        {
            InitializeComponent();
            BindingContext = new MultiLevelGroupingViewModel();
        }
    }
}