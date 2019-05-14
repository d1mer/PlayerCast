using System;

namespace PlayerCast.Models
{
    public class ChannelBasicInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string ItunesId { get; set; }
        public string Artists { get; set; }
        public DateTime LastReleaseDate { get; set; }
    }
}