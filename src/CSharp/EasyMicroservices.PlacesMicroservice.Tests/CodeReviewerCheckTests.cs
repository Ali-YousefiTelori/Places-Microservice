using CodeReviewer.Engine;
using EasyMicroservices.PlacesMicroservice.Contracts.Common;
using EasyMicroservices.PlacesMicroservice.Database.Entities;
using EasyMicroservices.PlacesMicroservice.WebApi.Controllers;
using EasyMicroservices.Tests;

namespace EasyMicroservices.PlacesMicroservice.Tests
{
    public class CodeReviewerCheckTests : CodeReviewerTests
    {
        static CodeReviewerCheckTests()
        {
            //types to check (this will check all of types in assembly so no need to add all of types of assembly)
            AssemblyManager.AddAssemblyToReview(
                typeof(DatabaseBuilder),
                //typeof(CompileTimeClassesMappers),
                typeof(CountryEntity),
                typeof(CityBaseContract),
                typeof(CountryController));
        }
    }
}