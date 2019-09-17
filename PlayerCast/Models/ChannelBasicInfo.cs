using System;
using System.Collections.Generic;

namespace PlayerCast.Models
{
    public class Name
    {
        public string label { get; set; }
    }

    public class Uri
    {
        public string label { get; set; }
    }

    public class Author
    {
        public Name name { get; set; }
        public Uri uri { get; set; }
    }

    public class ImName
    {
        public string label { get; set; }
    }

    public class Attributes
    {
        public string height { get; set; }
    }

    public class ImImage
    {
        public string label { get; set; }
        public Attributes attributes { get; set; }
    }

    public class Summary
    {
        public string label { get; set; }
    }

    public class Attributes2
    {
        public string amount { get; set; }
        public string currency { get; set; }
    }

    public class ImPrice
    {
        public string label { get; set; }
        public Attributes2 attributes { get; set; }
    }

    public class Attributes3
    {
        public string term { get; set; }
        public string label { get; set; }
    }

    public class ImContentType
    {
        public Attributes3 attributes { get; set; }
    }

    public class Rights
    {
        public string label { get; set; }
    }

    public class Title
    {
        public string label { get; set; }
    }

    public class Attributes4
    {
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Link
    {
        public Attributes4 attributes { get; set; }
    }

    public class Attributes5
    {
        public string id { get; set; }
    }

    public class Id
    {
        public string label { get; set; }
        public Attributes5 attributes { get; set; }
    }

    public class Attributes6
    {
        public string href { get; set; }
    }

    public class ImArtist
    {
        public string label { get; set; }
        public Attributes6 attributes { get; set; }
    }

    public class Attributes7
    {
        public string id { get; set; }
        public string term { get; set; }
        public string scheme { get; set; }
        public string label { get; set; }
    }

    public class Category
    {
        public Attributes7 attributes { get; set; }
    }

    public class Attributes8
    {
        public string label { get; set; }
    }

    public class ImReleaseDate
    {
        public DateTime label { get; set; }
        public Attributes8 attributes { get; set; }
    }

    public class Entry
    {
        public ImName name { get; set; }
        public List<ImImage> image { get; set; }
        public Summary summary { get; set; }
        public ImPrice price { get; set; }
        public ImContentType contentType { get; set; }
        public Rights rights { get; set; }
        public Title title { get; set; }
        public Link link { get; set; }
        public Id id { get; set; }
        public ImArtist artist { get; set; }
        public Category category { get; set; }
        public ImReleaseDate releaseDate { get; set; }
    }

    public class Updated
    {
        public DateTime label { get; set; }
    }

    public class Rights2
    {
        public string label { get; set; }
    }

    public class Title2
    {
        public string label { get; set; }
    }

    public class Icon
    {
        public string label { get; set; }
    }

    public class Attributes9
    {
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }

    public class Link2
    {
        public Attributes9 attributes { get; set; }
    }

    public class Id2
    {
        public string label { get; set; }
    }

    public class Feed
    {
        public Author author { get; set; }
        public List<Entry> entry { get; set; }
        public Updated updated { get; set; }
        public Rights2 rights { get; set; }
        public Title2 title { get; set; }
        public Icon icon { get; set; }
        public List<Link2> link { get; set; }
        public Id2 id { get; set; }
    }

    public class RootObject
    {
        public Feed feed { get; set; }
    }
}