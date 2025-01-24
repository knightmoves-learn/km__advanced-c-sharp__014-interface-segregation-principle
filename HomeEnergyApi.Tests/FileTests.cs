using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using HomeEnergyApi.Controllers;
namespace HomeEnergyApi.Models;
using Xunit;


[TestCaseOrderer("HomeEnergyApi.Tests.Extensions.PriorityOrderer", "HomeEnergyApi.Tests")]
public class FileTests
{
    [Fact]
    public void DoesProgramFileInMyFirstApiExist()
    {
        string programFilePath = @"../../../../HomeEnergyApi/Program.cs";
        string programContent = File.ReadAllText(programFilePath);
        Assert.True(programContent.Contains("builder.Services.AddSingleton<IRepository<int, Home>, HomeRepository>();"), "HomeEnergyApi/Program.cs does not contain the line \"builder.Services.AddSingleton<IRepository<int, Home>, HomeRepository>();\"");
    }

    [Fact]
    public void IsApplicationFactoryDeleted()
    {
        string applicationFactoryFilePath = @"../../../../HomeEnergyApi/ApplicationFactory.cs";
        Assert.True(!File.Exists(applicationFactoryFilePath), "The file \"ApplicationFactory.cs\" has not been deleted.");
    }
}
