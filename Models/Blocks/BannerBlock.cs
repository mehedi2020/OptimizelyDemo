using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyDemo.Models.Blocks
{
    [SiteContentType(GUID = "11112222-6BC2-4753-902A-8670EDC5F311")]
    [SiteImageUrl]
    public class BannerBlock : SiteBlockData
    {

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual string Title { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 2)]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackGroundImage { get; set; }

        [Display(
      GroupName = SystemTabNames.Content,
      Order = 3
      )]
        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        public virtual string Description { get; set; }
    }
}
