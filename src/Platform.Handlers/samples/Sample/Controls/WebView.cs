﻿using Xamarin.Forms;
using Xamarin.Platform;

namespace Sample
{
	public class WebView : Xamarin.Forms.View, IWebView
	{
		public WebViewSource Source { get; }
	}
}
