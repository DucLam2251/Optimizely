using EPiServer.Web;
using New_Project.Models.Blocks;
using System.ComponentModel.DataAnnotations;

namespace New_Project.Models.Pages
{
    [SiteContentType(GUID = "222D8271-5CA3-4C72-BABC-3E8779233222")]
    [SiteImageUrl]
    public class NewsListPage : StandardPage
    {
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 305)]
        public virtual PageListBlock NewsList { get; set; }

        [Display(Order = 305)]
        [UIHint(Globals.SiteUIHints.StringsCollection)]
        [CultureSpecific]
        public virtual IList<string> UniqueSellingPoints { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Page image",
         Description = "Link to image that will be displayed on the page.",
         GroupName = SystemTabNames.Content,
         Order = 1)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image
        {
            get;
            set;
        }

    }
}
