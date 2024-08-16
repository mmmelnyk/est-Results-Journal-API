using Microsoft.EntityFrameworkCore;
using ResultsJournalApi.Database;

namespace ResultsJournalApi.Extentions
{
    public static class MigrationExtantions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();
        }
    }
}