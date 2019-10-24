using eBayScraper.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wyatt_Fleming.Models.ViewModels
{
	public class eBayBookListViewModel
	{
		public IEnumerable<Book> Books { get; set; }

		public string TimeToCompletion { get; set; }
	}
}
