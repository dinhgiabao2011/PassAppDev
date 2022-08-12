using PassAppDev.Models;

using System.Collections.Generic;

namespace PassAppDev.ViewModels
{
	public class BookNotificationViewModel
	{
		public IEnumerable<BookViewModel> BookViewModels { get; set; }

		public IEnumerable<Notification> Notifications { get; set; }
	}
}
