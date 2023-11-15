namespace EjercicioIntegrador2_YouTify.Helpers
{
    internal class ColorHelper
    {
        const int MAX_RGB_VALUE = 255;
        internal static Color InvertColor(Color value)
        {
            return Color.FromArgb(MAX_RGB_VALUE - value.R, MAX_RGB_VALUE - value.G, MAX_RGB_VALUE - value.B);
        }
    }
}