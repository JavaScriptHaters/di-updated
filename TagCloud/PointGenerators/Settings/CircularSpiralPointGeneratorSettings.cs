using System.Drawing;

namespace TagCloud.PointGenerators.Settings;

public record CircularSpiralPointGeneratorSettings(double radius, double angleOffset, Point center);