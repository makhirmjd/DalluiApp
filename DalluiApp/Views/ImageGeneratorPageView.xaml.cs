using DalluiApp.ViewModels;
using System.Threading.Tasks;

namespace DalluiApp.Views;

public partial class ImageGeneratorPageView : ContentPage
{
    private readonly ImageGeneratorPageViewModel imageGenerationPageViewModel;

    public ImageGeneratorPageView(ImageGeneratorPageViewModel imageGenerationPageViewModel)
	{
		InitializeComponent();
        this.imageGenerationPageViewModel = imageGenerationPageViewModel;
        BindingContext = this.imageGenerationPageViewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await imageGenerationPageViewModel.StartGeneration((labelTimer, lottie, imageBorder, imageAnimation, borderTime, buttonFinish));
    }
}