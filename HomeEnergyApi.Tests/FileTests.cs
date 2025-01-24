public class FileTests
{
    private static string programFilePath = @"../../../../HomeEnergyApi/Program.cs";
    private string programContent = File.ReadAllText(programFilePath);

    [Fact]
    public void DoesProgramFileAddSingletonServiceHomeRepository()
    {
        // string programFilePath = @"../../../../HomeEnergyApi/Program.cs";
        // string programContent = File.ReadAllText(programFilePath);
        bool containsHomeRepositorySingleton = programContent.Contains("builder.Services.AddSingleton<HomeRepository>();");
        Assert.True(containsHomeRepositorySingleton,
            "HomeEnergyApi/Program.cs does not add a Singleton Service of type `HomeRepository`");
    }

    [Fact]
    public void DoesProgramFileAddSingletonServiceIReadRepositoryWithRequiredServiceProviderHomeRepository()
    {
        // string programFilePath = @"../../../../HomeEnergyApi/Program.cs";
        // string programContent = File.ReadAllText(programFilePath);
        bool containsIReadSingleton = programContent.Contains("builder.Services.AddSingleton<IReadRepository<int, Home>>(provider => provider.GetRequiredService<HomeRepository>());");
        Assert.True(containsIReadSingleton,
            "HomeEnergyApi/Program.cs does not add a Singleton Service of type `IReadRepository` with the required Service Provider of type `HomeRepository`");
    }

    [Fact]
    public void DoesProgramFileAddSingletonServiceIWriteRepositoryWithRequiredServiceHomeProviderRepository()
    {
        // string programFilePath = @"../../../../HomeEnergyApi/Program.cs";
        // string programContent = File.ReadAllText(programFilePath);
        bool containsIWriteSingleton = programContent.Contains("builder.Services.AddSingleton<IWriteRepository<int, Home>>(provider => provider.GetRequiredService<HomeRepository>());");
        Assert.True(containsIWriteSingleton,
            //"HomeEnergyApi/Program.cs does not add a Singleton Service of type `IWriteRepository` with the required Service Provider of type `HomeRepository`");
            $"{programContent}");
    }
}
