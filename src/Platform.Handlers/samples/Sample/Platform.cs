using Xamarin.Forms;
using Xamarin.Platform.Handlers;
using RegistrarHandlers = Xamarin.Platform.Registrar;

namespace Sample
{
	public class Platform
	{
		static bool HasInit;

		public static void Init()
		{
			if (HasInit)
				return;

			HasInit = true;

			RegistrarHandlers.Handlers.Register<ActivityIndicator, ActivityIndicatorHandler>();
			RegistrarHandlers.Handlers.Register<Button, ButtonHandler>();
			RegistrarHandlers.Handlers.Register<Label, LabelHandler>();
			RegistrarHandlers.Handlers.Register<Slider, SliderHandler>();

			RegistrarHandlers.Handlers.Register<VerticalStackLayout, LayoutHandler>();
			RegistrarHandlers.Handlers.Register<HorizontalStackLayout, LayoutHandler>();
			RegistrarHandlers.Handlers.Register<FlexLayout, LayoutHandler>();
			RegistrarHandlers.Handlers.Register<Xamarin.Forms.StackLayout, LayoutHandler>();
		}
	}
}