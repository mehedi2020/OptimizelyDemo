using System.ComponentModel.DataAnnotations;
using EPiServer.Web;

namespace OptimizelyDemo.Models.Blocks;


[SiteContentType(GUID = "7E932EAF-6BC2-4753-902A-8670EDC5F311")]
[SiteImageUrl]
public class GetInTouchBlock : SiteBlockData
{

    [CultureSpecific]
    [Required(AllowEmptyStrings = false)]
    [Display(
    GroupName = SystemTabNames.Content,
    Order = 1)]
    public virtual string Heading { get; set; }

    [Display(GroupName = SystemTabNames.Content, Order = 2)]
    [CultureSpecific]
    [UIHint(UIHint.Image)]
    public virtual ContentReference Image { get; set; }

    [Display(
  GroupName = SystemTabNames.Content,
  Order = 3
  )]
    [CultureSpecific]
    [UIHint(UIHint.Textarea)]
    public virtual string Address { get; set; }
}
