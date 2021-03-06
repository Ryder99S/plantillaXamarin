using System;
using EssentialUIKit.AppLayout.Views;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
#if EnableAppCenterAnalytics
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
#endif

namespace EssentialUIKit.AppLayout
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell
    {
        public AppShell()
        {
            this.InitializeComponent();

            this.Navigating += this.AppShell_Navigating;

            Routing.RegisterRoute("templatepage", typeof(TemplatePage));
            Routing.RegisterRoute("templatehostpage", typeof(TemplateHostPage));
        }

        /// <summary>
        /// Invoked when the list item is selected.
        /// </summary>
        /// <param name="category">The Category</param>
        /// <param name="page">The Page</param>
#pragma warning disable CA1801 // Review unused parameters
        private static void PushEvent(string category, string page)
#pragma warning restore CA1801 // Review unused parameters
        {
#if EnableAppCenterAnalytics
            Analytics.TrackEvent(
                "Template Clicked",
                new Dictionary<string, string>
                {
                    {
                        "Category", category
                    },
                    {
                        "Page", page
                    }
                });
#endif
        }

        private void AppShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            // TODO:Pending
            var uriString = e.Target.Location.OriginalString;
            if (uriString.Contains("?"))
            {
                var pageNameEndIndex = uriString.IndexOf("?", StringComparison.Ordinal);
            }
        }
    }
}