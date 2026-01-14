

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SurveyHub.Data;

namespace SurveyHub.Data 
{
    public class SurveyDbContextFactory
    : IDesignTimeDbContextFactory<SurveyDbContext>
    {
        public SurveyDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<SurveyDbContext>()
                .UseSqlServer(
                    "Server=DESKTOP-KOF0GK9\\SQLEXPRESS;Database=SurveyAppDb;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;

            return new SurveyDbContext(options);
        }
    }
}


