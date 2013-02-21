using System.Data.Entity;

namespace Tejas.Domain.Infrastructure
{
        public abstract class DbContextBase : DbContext
        {
            static DbContextBase()
            {
                // Recommended since we're using EF codefirst with an existing Db
                //Database.SetInitializer<TContext>(null);
            }

            protected DbContextBase()
                : base("name=Tejas")
            {

            }

            protected DbContextBase(string connectionString)
                : base(connectionString)
            { }

            protected void RetrieveAndUpdate<T2>(int primaryKey, T2 entity) where T2 : class
            {
                var existing = Set<T2>().Find(primaryKey);
                var entry = Entry(existing);
                entry.CurrentValues.SetValues(entity);
            }
        }
    }
