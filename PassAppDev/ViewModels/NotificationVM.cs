using System;

namespace PassAppDev.ViewModels
{
	public class NotificationVM
	{
		public string CategoryName { get; set; }
		public string Decision { get; set; }
		public string Action { get; set; }
		public DateTime NotifiedAt { get; set; }
	}
}
