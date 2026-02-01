using KitCli;
using KitCli.Commands.Abstractions.Extensions;
using KitCli.Instructions.Abstractions;

var programAssembly = typeof(Program).Assembly;

var app = new CliAppBuilder()
    .WithCli<JobRoleFilteringCliApp>()
    .WithUserSecretSettings<JobRoleFilteringCliApp>()
    .WithSettings<InstructionSettings>()
    .WithServices(services => services
        .AddCommandsFromAssembly(programAssembly)
        .AddListAggregatorCommandArtefactsFromAssembly(programAssembly));

await app.Run();