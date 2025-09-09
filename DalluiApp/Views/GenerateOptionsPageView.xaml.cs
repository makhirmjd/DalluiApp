using DalluiApp.ViewModels;

namespace DalluiApp.Views;

public partial class GenerateOptionsPageView : ContentPage
{
    private readonly GenerateOptionsPageViewModel generateOptionsPageViewModel;

    public GenerateOptionsPageView(GenerateOptionsPageViewModel generateOptionsPageViewModel)
	{
		InitializeComponent();
        this.generateOptionsPageViewModel = generateOptionsPageViewModel;
        BindingContext = generateOptionsPageViewModel;

        // Remove underline/border from Editor
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
        {
#if ANDROID
            // Remove default underline (background) on Android
            handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
#elif IOS || MACCATALYST
            // Remove border/decoration on iOS
            handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.BorderStyle = UIKit.UITextViewBorderStyle.None;   // removes iOS-style underline/border
            handler.PlatformView.Layer.BorderWidth = 0;
            handler.PlatformView.Layer.BorderColor = UIKit.UIColor.Clear.CGColor;
#endif
        });

    }
}