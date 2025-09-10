using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkiaSharp.Extended.UI.Controls;
using System.Diagnostics;

namespace DalluiApp.ViewModels;

public partial class ImageGeneratorPageViewModel : ObservableObject
{
    private readonly Stopwatch stopwatch = new();

    public async Task StartGeneration((Label labelTimer, SKLottieView lottie, View imageBorder, View imageAnimation, View borderTime, View buttonFinish) views)
    {
        await Task.Delay(TimeSpan.FromSeconds(2)); // Simulate initial delay
        stopwatch.Start();

        CancellationTokenSource cts = new();

        using PeriodicTimer timer = new(TimeSpan.FromSeconds(1));
        try
        {
            int counter = 0;
            while (await timer.WaitForNextTickAsync(cts.Token))
            {
                if (counter == 5)
                {
                    cts.Cancel(); // Stop the timer after 5 ticks
                }

                int seconds = stopwatch.Elapsed.Seconds;
                views.labelTimer.Text = seconds.ToString();
                counter++;
            }
        }
        catch (TaskCanceledException)
        {
            await StopGeneration((views.lottie, views.imageBorder, views.imageAnimation, views.borderTime, views.buttonFinish));
        }
    }

    public async Task StopGeneration((SKLottieView lottie, View imageBorder, View imageAnimation, View borderTime, View buttonFinish) views)
    {
        stopwatch.Stop();

        await Task.Delay(2000);

        views.lottie.IsAnimationEnabled = false;
        views.lottie.IsVisible = false;
        views.imageBorder.IsVisible = true;
        views.imageAnimation.IsVisible = true;

        await Task.WhenAny(
            views.imageAnimation.ScaleTo(1.1, 1000),
            views.imageAnimation.FadeTo(0, 1000),
            views.borderTime.ScaleTo(1, 1000),
            views.borderTime.FadeTo(1, 1000));

        await views.borderTime.FadeTo(0, 300);
        await views.buttonFinish.ScaleTo(1, 1000);
    }
}
