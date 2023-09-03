namespace ProductivityTools.PhotoGallery.CoreObjects
{
    public class Gallery
    {
        public Gallery()
        {
            this.PhotoList = new List<Photo>();
            this.PhotoSizes = new List<int>();
        }
        public List<string> ReadGmails { get; set; }

        public List<Photo> PhotoList { get; set; }
        public List<int> PhotoSizes { get; set; }
    }
}