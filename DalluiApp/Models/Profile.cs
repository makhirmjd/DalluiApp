namespace DalluiApp.Models;

public class Profile
{
    public string? ProfileImage { get; set; }
    public string Name { get; set; } = default!;
    public int NoPhotos { get; set; }
}
