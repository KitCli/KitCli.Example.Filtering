using KitCli;
using KitCli.Example.Filtering;

var app = new CliAppBuilder()
    .WithCli<JobRoleFilteringCliApp>()
    .WithRegistry<JobRoleFilteringRegistry>();

await app.Run();