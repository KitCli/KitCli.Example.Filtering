using KitCli.Abstractions;
using KitCli.Commands.Abstractions.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace KitCli.Example.Filtering;

public class JobRoleFilteringRegistry : ICliAppBuilderRegistry
{
    public void Register(IServiceCollection services)
    {
        var programAssembly = typeof(Program).Assembly;

        services
            .AddCommandsFromAssembly(programAssembly)
            .AddListAggregatorCommandArtefactsFromAssembly(programAssembly);
    }
}