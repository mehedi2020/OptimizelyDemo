namespace OptimizelyDemo.Models.Pages; 
    [SiteContentType(DisplayName = "New Page", GUID = "e50c3e4f-62a4-45a1-baa5-1b3f30ecbe7f", Description = "Page with new layout", GroupName = Globals.GroupNames.Specialized)]
    [AvailableContentTypes(Availability.All, Include = new[] { typeof(NewPage) })]
    public class NewPage : SitePageData
{
        public virtual string MainContent { get; set; }
    } 
