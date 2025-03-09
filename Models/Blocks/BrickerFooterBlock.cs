using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyDemo.Models.Blocks
{ 
    /// <summary>
    /// Used to provide a composite property on the start page to set site logotype settings
    /// </summary>
    [SiteContentType(
        GUID = "19854019-91A5-4B93-8623-17F038346001",
        AvailableInEditMode = true)] // Should not be created and added to content areas by editors, the SiteLogotypeBlock is only used as a property type
    [SiteImageUrl]
    public class BrickerFooterBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)] // Updated Order
        public virtual ContentReference BackGroundImage { get; set; }

        [Display(Order = 1, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterTitle { get; set; }

        [Display(Order = 2, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterDescription { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [UIHint(UIHint.Image)]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)] // Updated Order
        public virtual ContentReference FooterMap { get; set; }

        [Display(Order = 3, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterContactUS { get; set; }

        [Display(Order = 4, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterContactUSPhone { get; set; }

        [Display(Order = 5, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterContactUSEmail1 { get; set; }

        [Display(Order = 6, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterContactUSEmail2 { get; set; }

        [Display(Order = 7, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterCopyWriteTitle { get; set; }

        [Display(Order = 8, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual string FooterCopyWriteDescription { get; set; }

        [Display(Order = 9, GroupName = SystemTabNames.Content)]
        [Required]
        public virtual Url FooterLink { get; set; }
    }
}