using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlayerCast.Models
{
    public class ChannelsContext : DbContext
    {
        public DbSet<ChannelBasicInfo> ChannelsBasic { get; set; }
        public DbSet<RequestUrl> RequestsUrl { get; set; }

        public ChannelsContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=ChannelsDb.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RequestUrl>().HasData(new RequestUrl[]
            {
                new RequestUrl { Id = 1, Name = "TopRusPodcast", Url = "https://itunes.apple.com/ru/rss/topaudiopodcasts/limit=200/json"},
                new RequestUrl { Id = 2, Name = "TopRusPodcastGenre", Url = "https://itunes.apple.com/ru/rss/topaudiopodcasts/genre=/limit=200/json"},
                new RequestUrl { Id = 3, Name = "RusPodcast1", Url = "https://itunes.apple.com/search?term=ru+podcasts&media=podcast&limit=200"},
                new RequestUrl { Id = 4, Name = "RusPodcast2", Url = "https://itunes.apple.com/search?term=podcast&sentity=podcast&country=RU&limit=200"},
                new RequestUrl { Id = 5, Name = "TopEnglishPodcast", Url = "https://itunes.apple.com/rss/topaudiopodcasts/limit=200/json"},
                new RequestUrl { Id = 6, Name = "EnglishPodcast", Url = "https://itunes.apple.com/search?term=podcast&sentity=podcast&limit=200"},
                new RequestUrl { Id = 7, Name = "TopEnglishPodcastGenre", Url = "https://itunes.apple.com/rss/topaudiopodcasts/genre=/limit=200/json"},
                new RequestUrl { Id = 8, Name = "SearchPodcast", Url = "https://itunes.apple.com/search?term="}
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}