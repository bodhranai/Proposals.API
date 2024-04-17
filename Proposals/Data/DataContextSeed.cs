using Proposals.API.Entities;

namespace Proposals.API.Data
{
    public class DataContextSeed
    {
        public static async Task SeedAsync(DataContext dataContext, ILogger<DataContextSeed> logger)
        {
            if (!dataContext.Users.Any())
            {
                dataContext.Users.AddRange(GetPreconfiguredUsers());
                await dataContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(DataContext).Name);
            } 
            if (!dataContext.Experiment.Any())
            {
                dataContext.Experiment.AddRange(GetPreconfiguredExperiments());
                await dataContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(DataContext).Name);
            }
        }

        private static IEnumerable<Experiment> GetPreconfiguredExperiments()
        {
            return new List<Experiment>
           {
                new Experiment
                {
                     Abstract = "Advanced Light Source",
                      ProposalNumber = Guid.NewGuid(),
                      CreatedBy ="Ann",
                       CreatedDate = DateTime.Now,
                        LastModifiedBy ="Ann",
                         LastModifiedDate=DateTime.Now,
                         BeginDate = DateTime.Now,
                         EndDate=DateTime.Now.AddDays(30)



                }
           };
        }

        private static IEnumerable<User> GetPreconfiguredUsers()
        {
            return new List<User>
            {
                new User()
                {
                     Name = "Ann",
                     OrcId = 123,
                      CreatedBy ="Ann",
                       CreatedDate = DateTime.Now,
                        LastModifiedBy ="Ann",
                         LastModifiedDate=DateTime.Now

                }

            };
        }
    }
}
