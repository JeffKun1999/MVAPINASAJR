using MVAPINASAJR.ViewModels;

namespace MVAPINASAJR.Views;

public partial class ApodPage2JR : ContentPage
{
	public ApodPage2JR()
	{
        InitializeComponent();
        BindingContext = new ApodViewModelJR();
    }
}