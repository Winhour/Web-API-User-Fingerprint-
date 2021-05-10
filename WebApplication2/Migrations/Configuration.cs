namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.WebApplication2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.WebApplication2Context context)
        {
            context.User_Data.AddOrUpdate(x => x.Id,
                new User_Data() { Id = 1, First_Name = "Lionel", Last_Name = "Messi", Age = 31, Gender = "Male" },
                new User_Data() { Id = 2, First_Name = "Cristiano", Last_Name = "Ronaldo", Age = 33, Gender = "Male" },
                new User_Data() { Id = 3, First_Name = "Marija", Last_Name = "Sharapova", Age = 31, Gender = "Female" }
                );

            context.Fingerprints.AddOrUpdate(x => x.Id,
                new Fingerprints()
                {
                    Id = 1,
                    LThumb = null,
                    LIndex = null,
                    LMiddle = null,
                    LRing = null,
                    LLittle = null,
                    RThumb = null,
                    RIndex = null,
                    RMiddle = null,
                    RRing = null,
                    RLittle = null,
                    LThumbC = null,
                    LIndexC = null,
                    LMiddleC = null,
                    LRingC = null,
                    LLittleC = null,
                    RThumbC = null,
                    RIndexC = null,
                    RMiddleC = null,
                    RRingC = null,
                    RLittleC = null,
                },
                new Fingerprints()
                {
                    Id = 2,
                    LThumb = null,
                    LIndex = null,
                    LMiddle = null,
                    LRing = null,
                    LLittle = null,
                    RThumb = null,
                    RIndex = null,
                    RMiddle = null,
                    RRing = null,
                    RLittle = null,
                    LThumbC = null,
                    LIndexC = null,
                    LMiddleC = null,
                    LRingC = null,
                    LLittleC = null,
                    RThumbC = null,
                    RIndexC = null,
                    RMiddleC = null,
                    RRingC = null,
                    RLittleC = null,
                },
                new Fingerprints()
                {
                    Id = 3,
                    LThumb = null,
                    LIndex = null,
                    LMiddle = null,
                    LRing = null,
                    LLittle = null,
                    RThumb = null,
                    RIndex = null,
                    RMiddle = null,
                    RRing = null,
                    RLittle = null,
                    LThumbC = null,
                    LIndexC = null,
                    LMiddleC = null,
                    LRingC = null,
                    LLittleC = null,
                    RThumbC = null,
                    RIndexC = null,
                    RMiddleC = null,
                    RRingC = null,
                    RLittleC = null,
                }
                );
        }


    }
}