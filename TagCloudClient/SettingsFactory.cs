using System.Drawing;
using TagCloud.CloudLayouter.Settings;
using TagCloud.PointGenerators;
using TagCloud.ImageGenerator;
using TagCloud.ImageSaver;
using TagCloud.PointGenerators.Settings;
using TagCloud.WordsReader.Settings;

namespace TagCloudClient;

public class SettingsFactory
{
    public static FileReaderSettings BuildFileReaderSettings(Options options)
        => new(options.FilePath, options.UsingEncoding);

    public static BitmapSettings BuildBitmapSettings(Options options)
        => new(options.Size, options.Font, options.BackgroundColor, options.ForegroundColor);

    public static CircularSpiralPointGeneratorSettings BuildCircularSpiralPointGeneratorSettings(Options options)
        => new(options.Step, options.DeltaAngle, new Point(options.Size.Width/2, options.Size.Height / 2));

    public static CircularCloudLayouterSettings BuildCircularCloudLayouterSettings(Options options)
        => new(options.Center);

    public static WordFileReaderSettings BuildWordReaderSettings(Options options)
        => new(options.FilePath);

    public static CsvFileReaderSettings BuildCsvReaderSettings(Options options)
        => new(options.FilePath, options.Culture);

    public static FileSaveSettings BuildFileSaveSettings(Options options)
        => new(options.ImageName, options.ImageFormat);
}