using System.Drawing;

namespace TagCloud.ImageSaver;

public class BitmapFileSaver(string imageName, string imageFormat) : IImageSaver
{
    private readonly List<string> supportedFormats = ["png", "jpg", "jpeg", "bmp"];

    public BitmapFileSaver(FileSaveSettings settings)
        : this(settings.ImageName, settings.ImageFormat)
    { }

    public string Save(Bitmap image)
    {
        if (!supportedFormats.Contains(imageFormat))
            throw new ArgumentException($"Unsupported image format: {imageFormat}");

        var fullImageName = $"{imageName}.{imageFormat}";
        image.Save(fullImageName);
        return Path.Combine(Directory.GetCurrentDirectory(), fullImageName);
    }
}