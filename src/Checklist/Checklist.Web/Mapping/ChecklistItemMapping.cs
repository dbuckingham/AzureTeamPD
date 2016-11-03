using Checklist.Web.Data;

namespace Checklist.Web.Mapping
{
    public class ChecklistItemMapping : BaseEntityMapping<ChecklistItem>
    {
        public ChecklistItemMapping()
        {
            Property(p => p.Description).IsRequired();
        }
    }
}