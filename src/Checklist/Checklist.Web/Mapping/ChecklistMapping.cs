namespace Checklist.Web.Mapping
{
    public class ChecklistMapping : BaseEntityMapping<Data.Checklist>
    {
        public ChecklistMapping()
        {
            Property(p => p.Name).IsRequired();
        }
    }
}