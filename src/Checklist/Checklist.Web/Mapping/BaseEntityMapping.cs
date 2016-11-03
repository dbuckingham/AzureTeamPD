using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Checklist.Web.Data;

namespace Checklist.Web.Mapping
{
    public abstract class BaseEntityMapping<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        protected BaseEntityMapping()
        {
            HasKey(p => p.Id).Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}