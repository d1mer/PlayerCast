using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using System.IO;
using PlayerCast.Models;
using Windows.Data.Json;
using Windows.UI.Popups;

namespace PlayerCast.Utilities
{
    class GetChannelsRepository
    {
        //private static List<ChannelBasicInfo> channelsCache;

        public static async Task/*<List<ChannelBasicInfo>>*/ GetChannelsList()
        {
            // TODO: сделать проверку даты последнего обращения к itunes. 
            // В случае, если оно было в течении суток, получать список каналов из файла.

            // TODO: сделать проверку наличия сети
            // TODO: сделать проверку, искать ли подкасты на английском языке

            string requestUrl = "";
            //using(ChannelsContext db = new ChannelsContext())
            //{
            //    var s = db.RequestsUrl.Where(q => q.Name == "TopRusPodcast");
            //    requestUrl = s.ElementAt(0).Url;
            //}

            using(HttpClient client = new HttpClient())
            {
                try
                {
                    string s = await client.GetStringAsync(new System.Uri("https://itunes.apple.com/ru/rss/topaudiopodcasts/json"));
                    //JsonArray jsonArray = new JsonArray();
                    //JsonArray.TryParse(s, out jsonArray);

                    JsonObject jo = new JsonObject();
                    jo = JsonObject.Parse(s);
                    //var dialog = new MessageDialog(JsonArray.TryParse(s, out jsonArray).ToString());
                    MessageDialog dialog = new MessageDialog(jo.First().ToString());
                    await dialog.ShowAsync();
                }
                catch(Exception ex) { throw ex; }
            }
        }
    }
}