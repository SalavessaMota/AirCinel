namespace FinalProjectPOO.Classes;

public class ThemeColor
{
    /// <summary>
    /// Changes the brightness of a color based on a correction factor.
    /// </summary>
    /// <param name="color">The color to be adjusted.</param>
    /// <param name="correctionFactor">Correction factor to adjust the brightness. Can be negative or positive.</param>
    /// <returns>A new color with adjusted brightness.</returns>
    public static Color ChangeColorBrightness(Color color, double correctionFactor)
    {
        double red = color.R;
        double green = color.G;
        double blue = color.B;

        if (correctionFactor < 0) // If the correction factor is less than 0
        {
            correctionFactor = 1 + correctionFactor; // Add the correction factor to 1
            red *= correctionFactor; // Multiply the red value by the correction factor
            green *= correctionFactor; // Multiply the green value by the correction factor
            blue *= correctionFactor; // Multiply the blue value by the correction factor
        }
        else // If the correction factor is greater than or equal to 0
        {
            red = (255 - red) * correctionFactor + red; // Calculate the red value
            green = (255 - green) * correctionFactor + green; // Calculate the green value
            blue = (255 - blue) * correctionFactor + blue; // Calculate the blue value
        }
        // Return the color with the calculated values
        return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
    }
}
