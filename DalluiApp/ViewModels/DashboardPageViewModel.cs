using CommunityToolkit.Mvvm.ComponentModel;
using DalluiApp.Models;
using System.Collections.ObjectModel;

namespace DalluiApp.ViewModels;

public partial class DashboardPageViewModel : ObservableObject
{
    public ObservableCollection<Profile> Profiles { get; set; } = [
        new ()
        {
            Name = "Hector",
            ProfileImage = "profile1.jpg",
            NoPhotos = 12
        },
        new ()
        {
            Name = "Maddy",
            ProfileImage = "profile2.jpg",
            NoPhotos = 5
        },
        new ()
        {
            Name = "Henry",
            ProfileImage = "profile3.jpg",
            NoPhotos = 25
        }];
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; } = [
        new()
        {
            ImagePath = "dashboard1.jpg",
            MainKeyword = "Castle",
            Keywords = ["Epic, hill, mountain, trees, blue sky"]
        },
        new()
        {
            ImagePath = "dashboard2.jpg",
            MainKeyword = "Mountains",
            Keywords = ["Landscape, photorealistic, dawn, mountains, moon"]
        },
        new()
        {
            ImagePath = "dashboard3.jpg",
            MainKeyword = "Robot",
            Keywords = ["AI, robotic, human, light, metal"]
        },];
}
