using System.Collections.Generic;

namespace Checklist.Web.Data
{
    public class Checklist : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ChecklistItem> Items { get; set; } 
    }
}