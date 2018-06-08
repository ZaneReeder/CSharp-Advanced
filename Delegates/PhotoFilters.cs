namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Applied Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Applied Contrast");
        }

        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Applied Resize");
        }
    }
}