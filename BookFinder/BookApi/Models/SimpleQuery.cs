/*
 * This file contains several classes all related to deserializing the JSON returned by the Google Book API
 * when performing a simple query against publically stored books.
 */

namespace BookApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SimpleQuery
    {
        public SimpleQuery()
        {
            country = "";
            viewability = "";
            textToSpeechPermission = "";
            epub = new Epub();
            pdf = new Pdf();
            webReaderLink = "";
            accessViewStatus = "";
        }

        public string country { get; set; }
        public string viewability { get; set; }
        public bool embeddable { get; set; }
        public bool publicDomain { get; set; }
        public string textToSpeechPermission { get; set; }
        public Epub epub { get; set; }
        public Pdf pdf { get; set; }
        public string webReaderLink { get; set; }
        public string accessViewStatus { get; set; }
        public bool quoteSharingAllowed { get; set; }
    }

    public class Epub
    {
        public Epub()
        {
            acsTokenLink = "";
        }

        public bool isAvailable { get; set; }
        public string acsTokenLink { get; set; }
    }

    public class ImageLinks
    {
        public ImageLinks()
        {
            smallThumbnail = "";
            thumbnail = "";
        }

        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }

    public class IndustryIdentifier
    {
        public IndustryIdentifier()
        {
            type = "";
            identifier = "";
        }

        public string type { get; set; }
        public string identifier { get; set; }
    }

    public class Item
    {
        public Item()
        {
            kind = "";
            id = "";
            etag = "";
            selfLink = "";
            volumeInfo = new VolumeInfo();
            saleInfo = new SaleInfo();
            accessInfo = new SimpleQuery(); //NOTE: this might cause problems
            searchInfo = new SearchInfo();
        }

        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
        public SaleInfo saleInfo { get; set; }
        public SimpleQuery accessInfo { get; set; }
        public SearchInfo searchInfo { get; set; }
    }

    public class ListPrice
    {
        public ListPrice()
        {
            currencyCode = "";
        }

        public double amount { get; set; }
        public string currencyCode { get; set; }
        public int amountInMicros { get; set; }
    }

    public class Offer
    {
        public Offer()
        {
            listPrice = new ListPrice();
            retailPrice = new RetailPrice();
        }

        public int finskyOfferType { get; set; }
        public ListPrice listPrice { get; set; }
        public RetailPrice retailPrice { get; set; }
        public bool giftable { get; set; }
    }

    public class PanelizationSummary
    {
        public bool containsEpubBubbles { get; set; }
        public bool containsImageBubbles { get; set; }
    }

    public class Pdf
    {
        public Pdf()
        {
            acsTokenLink = "";
        }

        public bool isAvailable { get; set; }
        public string acsTokenLink { get; set; }
    }

    public class ReadingModes
    {
        public bool text { get; set; }
        public bool image { get; set; }
    }

    public class RetailPrice
    {
        public RetailPrice()
        {
            currencyCode = "";
        }

        public double amount { get; set; }
        public string currencyCode { get; set; }
        public int amountInMicros { get; set; }
    }

    public class Root
    {
        public Root()
        {
            kind = "";
            items = new List<Item>();
        }

        public string kind { get; set; }
        public int totalItems { get; set; }
        public List<Item> items { get; set; }
    }

    public class SaleInfo
    {
        public SaleInfo()
        {
            //value properties
            country = "";
            saleability = "";
            buyLink = "";

            //reference properties
            listPrice = new ListPrice();
            retailPrice = new RetailPrice();
            offers = new List<Offer>();
        }

        public string country { get; set; }
        public string saleability { get; set; }
        public bool isEbook { get; set; }
        public ListPrice listPrice { get; set; }
        public RetailPrice retailPrice { get; set; }
        public string buyLink { get; set; }
        public List<Offer> offers { get; set; }
    }

    public class SearchInfo
    {
        public string textSnippet { get; set; } = "";
    }

    public class VolumeInfo
    {
        public VolumeInfo()
        {
            //value properties
            title = "";
            subtitle = "";
            publisher = "";
            publishedDate = "";
            description = "";
            printType = "";
            maturityRating = "";
            contentVersion = "";
            language = "";
            previewLink = "";
            infoLink = "";
            canonicalVolumeLink = "";

            //reference properties
            industryIdentifiers = new List<IndustryIdentifier>();
            readingModes = new ReadingModes();
            categories = new List<string>();
            panelizationSummary = new PanelizationSummary();
            imageLinks = new ImageLinks();
            authors = new List<string>();
        }

        public string title { get; set; }
        public string subtitle { get; set; }
        public List<string> authors { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public List<IndustryIdentifier> industryIdentifiers { get; set; }
        public ReadingModes readingModes { get; set; }
        public int pageCount { get; set; }
        public string printType { get; set; }
        public List<string> categories { get; set; }
        public double averageRating { get; set; }
        public int ratingsCount { get; set; }
        public string maturityRating { get; set; }
        public bool allowAnonLogging { get; set; }
        public string contentVersion { get; set; }
        public PanelizationSummary panelizationSummary { get; set; }
        public ImageLinks imageLinks { get; set; }
        public string language { get; set; }
        public string previewLink { get; set; }
        public string infoLink { get; set; }
        public string canonicalVolumeLink { get; set; }
    }

}
