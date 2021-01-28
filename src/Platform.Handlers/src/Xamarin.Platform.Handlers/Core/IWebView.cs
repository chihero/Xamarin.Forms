﻿using Xamarin.Forms;

namespace Xamarin.Platform
{
	public interface IWebView : IView
	{
		WebViewSource2 Source { get; set; }
		bool CanGoBack { get; set; }
		bool CanGoForward { get; set; }
	}
}