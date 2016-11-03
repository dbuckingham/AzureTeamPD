namespace Checklist.Web.Migrations.Factories
{
    public static class ChecklistFactory
    {
        private static Data.Checklist[] _checklists;

        public static Data.Checklist[] All {
            get
            {
                if(_checklists != null) return _checklists;

                _checklists = Generate();

                return _checklists;
            }
            set { _checklists = value; }
        }

        private static Data.Checklist[] Generate()
        {
            return new []
            {
                new Data.Checklist() { Name = "My Checklist" }
            };
        }
    }
}