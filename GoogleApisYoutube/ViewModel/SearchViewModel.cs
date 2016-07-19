using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApisYoutube.ViewModel
{
    public class SearchViewModel
    {
        public string SearchText { get; set; }

        private SearchJsonModel _SearchResult = new SearchJsonModel();
        public SearchJsonModel SearchResult
        {
            get { return _SearchResult ?? new SearchJsonModel(); }
            set { _SearchResult = value; }
        }
    }

    public class SearchJsonModel
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public Pageinfo pageInfo { get; set; }
        public Item[] items { get; set; }
    }


    public class Pageinfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public Id id { get; set; }
        public Snippet snippet { get; set; }
    }

    public class Id
    {
        public string kind { get; set; }
        public string videoId { get; set; }
    }

    public class Snippet
    {
        public DateTime publishedAt { get; set; }
        public string channelId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string channelTitle { get; set; }
        public string liveBroadcastContent { get; set; }
    }

    public class Thumbnails
    {
        [JsonProperty("default")]
        public Default _default { get; set; }
        public Medium medium { get; set; }
        public High high { get; set; }
    }

    public class Default
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Medium
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class High
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

}
