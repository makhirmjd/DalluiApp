using DalluiApp.Models;
using System.Collections.ObjectModel;

namespace DalluiApp.ViewModels;

public class GenerateOptionsPageViewModel
{
    public ObservableCollection<OptionItem> Options { get; set; } = 
        [
            new() {  Title = "World" }, 
            new() { Title = "Winter" }, 
            new() { Title = "Trees" }];

    public ObservableCollection<ArtStyle> Styles { get; set; } = 
        [
        new() { Name = "Cartoon", ImageUrl = "cartoon.jpg" },
        new() { Name = "Realistic", ImageUrl = "realistic.jpg" },
        new() { Name = "Watercolor Art", ImageUrl = "watercolor.jpg" },
        new() { Name = "Isometric", ImageUrl = "isometric.jpg" },
        new() { Name = "Pop Art", ImageUrl = "popart.jpg" },
        new() { Name = "Surrealism", ImageUrl = "surrealism.jpg" },
        new() { Name = "Minimalism", ImageUrl = "minimalism.jpg" },
        new() { Name = "Funko", ImageUrl = "funko.jpg" },
        new() { Name = "Anime", ImageUrl = "anime.jpg" },
        new() { Name = "Storybook", ImageUrl = "storybook.jpg" }];
}
