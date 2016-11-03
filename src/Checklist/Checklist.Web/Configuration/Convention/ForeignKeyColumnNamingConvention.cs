using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Checklist.Web.Configuration.Convention
{
    public class ForeignKeyColumnNamingConvention : IStoreModelConvention<AssociationType>
    {
        public void Apply(AssociationType association, DbModel model)
        {
            // Identify a ForeignKey property
            if (!association.IsForeignKey) return;

            // rename FK column
            var constraint = association.Constraint;

            if (DoPropertiesHaveDefaultNames(constraint.FromProperties, constraint.ToProperties))
            {
                NormalizeForeignKeyProperties(constraint.FromProperties);
            }

            if (DoPropertiesHaveDefaultNames(constraint.ToProperties, constraint.FromProperties))
            {
                NormalizeForeignKeyProperties(constraint.ToProperties);
            }
        }

        private static bool DoPropertiesHaveDefaultNames(IReadOnlyCollection<EdmProperty> properties,
            IReadOnlyList<EdmProperty> otherEndProperties)
        {
            if (properties.Count != otherEndProperties.Count) return false;

            return !properties.Where((t, i) => !t.Name.EndsWith("_" + otherEndProperties[i].Name)).Any();
        }

        private static void NormalizeForeignKeyProperties(IEnumerable<EdmProperty> properties)
        {
            foreach (var property in properties)
            {
                var defaultPropertyName = property.Name;
                var ichUnderscore = defaultPropertyName.IndexOf('_');

                if (ichUnderscore <= 0) continue;

                property.Name = defaultPropertyName.Substring(0, ichUnderscore);
            }
        }
    }
}