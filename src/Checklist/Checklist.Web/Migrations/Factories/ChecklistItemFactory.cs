using System.Linq;
using Checklist.Web.Data;

namespace Checklist.Web.Migrations.Factories
{
    public static class ChecklistItemFactory
    {
        private static ChecklistItem[] _checklistItems;

        public static ChecklistItem[] All {
            get
            {
                if(_checklistItems != null) return _checklistItems;

                _checklistItems = Generate();

                return _checklistItems;
            }
            set { _checklistItems = value; }
        }

        private static ChecklistItem[] Generate()
        {
            return new ChecklistItem[]
            {
                new ChecklistItem() {Description = "Task 1", Checklist = ChecklistFactory.All.Single(cl => cl.Name == "My Checklist")},
                new ChecklistItem() {Description = "Task 2", Checklist = ChecklistFactory.All.Single(cl => cl.Name == "My Checklist")},
                new ChecklistItem() {Description = "Task 3", Checklist = ChecklistFactory.All.Single(cl => cl.Name == "My Checklist")}
            };
        }
    }
}