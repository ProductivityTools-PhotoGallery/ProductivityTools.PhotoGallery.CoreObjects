namespace ProductivityTools.PhotoGallery.CoreObjects
{
    public class Gallery
    {
        public Gallery()
        {
            this.ImageList = new List<Image>();
            this.ImageSizes = new List<int>();
        }
        public List<string> ReadGmails { get; set; }

        public List<Image> ImageList { get; set; }
        public List<int> ImageSizes { get; set; }
    }
}