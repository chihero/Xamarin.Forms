﻿using System;

namespace Xamarin.Platform.Handlers
{
	public partial class WebViewHandler : AbstractViewHandler<IWebView, object>
	{
		protected override object CreateNativeView() => throw new NotImplementedException();

		public static void MapSource(IViewHandler handler, IWebView webView) { }
		public static void MapCanGoBack(IViewHandler handler, IWebView webView) { }
		public static void MapCanGoForward(IViewHandler handler, IWebView webView) { }
	}
}