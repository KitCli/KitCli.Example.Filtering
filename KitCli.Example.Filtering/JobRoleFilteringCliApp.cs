using KitCli;
using KitCli.Commands.Abstractions.Io.Outcomes;
using KitCli.Workflow.Abstractions;

public class JobRoleFilteringCliApp : CliApp
{
    public JobRoleFilteringCliApp(ICliWorkflow workflow, ICliCommandOutcomeIo io) : base(workflow, io)
    {
    }
}