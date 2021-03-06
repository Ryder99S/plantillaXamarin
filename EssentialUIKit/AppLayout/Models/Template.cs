using Xamarin.Forms.Internals;

namespace EssentialUIKit.AppLayout.Models
{
    [Preserve(AllMembers = true)]
    public class Template
    {
        #region Constructor

        public Template()
        {
        }

        public Template(string name, string description, string pageName, bool layoutFullScreen, string updateType, bool isUpdate, string image, string darkimage)
        {
            this.Name = name;
            this.Description = description;
            this.PageName = pageName;
            this.LayoutFullscreen = layoutFullScreen;
            this.UpdateType = updateType;
            this.IsUpdate = isUpdate;
            this.Image = image;
            this.DarkModeImage = darkimage;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public string Description { get; set; }

        public string PageName { get; set; }

        public bool LayoutFullscreen { get; set; }

        public string UpdateType { get; set; }

        public bool IsUpdate { get; set; }

        public string Image { get; set; }

        public string DarkModeImage { get; set; }

        #endregion
    }
}