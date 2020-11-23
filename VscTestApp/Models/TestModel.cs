using System;

namespace VscTestApp.Models
{
    public class TestModel
    {
        public int Id { get; set; }

        public Guid ItemGuid { get; set; }

        public string Title { get; set; }

        public decimal RentalPricePerDay { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public string Slug { get; set; }

        public bool IsPublished { get; set; }

        public bool IsApproved { get; set; }

        public bool AddedToFavorites { get; set; }

        public TestPictureModel Picture { get; set; }
    }
}