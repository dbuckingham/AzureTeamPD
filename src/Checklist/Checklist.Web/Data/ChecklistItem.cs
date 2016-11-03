using System;

namespace Checklist.Web.Data
{
    public class ChecklistItem : BaseEntity
    {
        public string Description { get; set; }
        public DateTime? DateCompleted { get; set; }

        public virtual Data.Checklist Checklist { get; set; }
    }
}