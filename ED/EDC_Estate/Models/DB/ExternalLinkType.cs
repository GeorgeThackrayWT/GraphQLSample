using System.Collections.Generic;

namespace EDC_Estate.Models.DB
{
    public partial class ExternalLinkType
    {
        public ExternalLinkType()
        {
            ExternalLink = new HashSet<ExternalLink>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ExternalLink> ExternalLink { get; set; }
    }
}
