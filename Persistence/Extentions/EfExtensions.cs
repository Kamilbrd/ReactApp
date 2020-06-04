using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Extentions
{
    public static class EfExtensions
    {
        public static ValueTask<T> FindIdAsync<T>(this DbSet<T> dbSet, object key, CancellationToken cancellationToken)
			where T : class
			=> dbSet.FindAsync(new object[] { key }, cancellationToken);
    }
}