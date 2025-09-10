using CommunityToolkit.Maui.Animations;

namespace DalluiApp.Animations;

public partial class FadeScaleAnimation : BaseAnimation
{
    public double Scale { get; set; } = 1.0;
    public double TargetOpacity { get; set; } = 1.0;

    public override Task Animate(VisualElement view, CancellationToken token = default)
    {
        Task scaleTask = view.ScaleTo(Scale, Length, Easing);
        Task fadeTask = view.FadeTo(TargetOpacity, Length, Easing);
        return Task.WhenAll(scaleTask, fadeTask);
    }
}
