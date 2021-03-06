using EssentialUIKit.AppLayout.Controls;
using EssentialUIKit.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TemplateHostView), typeof(TemplateHostViewRenderer))]

namespace EssentialUIKit.iOS
{
    public class TemplateHostViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            var pageView = e?.NewElement as TemplateHostView;

#pragma warning disable CA2000 // Dispose objects before losing scope
            var nativePage = GetNativeView(pageView.Template, pageView);
#pragma warning restore CA2000 // Dispose objects before losing scope

            this.SetNativeControl((nativePage as UIViewController).View);
        }

        private static Page GetPage(VisualElement element)
        {
            while (true)
            {
                if (element is Page)
                {
                    return (Page)element;
                }

                element = element.Parent as VisualElement;
            }
        }

        private static IVisualElementRenderer GetNativeView(Page formsView, TemplateHostView parent)
        {
            var safeAreaHeight = AppSettings.Instance.SafeAreaHeight;

            if (formsView == null)
            {
                return null;
            }

            var renderer = Platform.GetRenderer(formsView);

            if (renderer == null)
            {
                renderer = Platform.CreateRenderer(formsView);
                Platform.SetRenderer(formsView, renderer);
            }

            formsView.Parent = GetPage(parent);

            formsView.Layout(new Rectangle(0, 0, parent.WidthRequest, parent.HeightRequest - safeAreaHeight));

            return renderer;
        }
    }
}