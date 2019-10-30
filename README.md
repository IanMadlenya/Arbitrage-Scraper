# Arbitrage-Scraper
A web-scraper written in C# that scrapes data from eBay auctions and Amazon product listings and compares the two for arbitrage opporunities

This is the a web-sraping project I have been working on for a while. The idea is to scrape data from eBay listings in real time and then compare them to prices on Amazon for the same item and then be notified when certain proifitablity indicators are present.

# eBay Scraping
I am first implementing the eBay scraper side before the Amazon one.

I have recently implemented an HTTPClientFactory service which distributes an HTTPClient each time the method is called to scrape data form eBay.

As for the scraping itself, I use the HTMLAgilityPack nuget package to make a traversable DOM from the raw HTML retrieved from eBay and then use LINQ to actually traverse the page and pull out the data I am after.

I refactored the scraping method to take advantage of executing calls concurrently to speed up the method execution time.

There is a <Book> model that I write all of the data to, however my current method of extracting individual product ISBN info does not seem to be working so that is what I am currently trying to fix, once that is done I will be working on figuring out how to use the <Book> model to retrieve comparable data from Amazon in a concurrent manner.
