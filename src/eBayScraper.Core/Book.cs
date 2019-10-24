using System;
using System.Collections.Generic;
using System.Text;

namespace eBayScraper.Core
{
	public class Book
	{

		public int Id { get; set; }
		public string ProductName { get; set; }
		public string ListingTitle { get; set; }
		public ConditionType Condition { get; set; }
		public double CurrentBid { get; set; }
		public double ShippingPrice { get; set; }
		public string Url { get; set; }
		public long ISBN { get; set; }
		public DateTime TimeLeft { get; set; }

		public double TotalPrice => ShippingPrice + CurrentBid;
	}
}
