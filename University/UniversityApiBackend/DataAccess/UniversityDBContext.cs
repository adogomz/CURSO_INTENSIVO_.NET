using Microsoft.EntityFrameworkCore;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {

        }
        // TODO: AÑADIR DBSETS (TABLAS )
    }
}
