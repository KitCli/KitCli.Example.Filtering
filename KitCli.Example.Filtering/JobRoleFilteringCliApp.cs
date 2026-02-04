using KitCli.Abstractions.Io;
using KitCli.Workflow.Abstractions;

namespace KitCli.Example.Filtering;

public class JobRoleFilteringCliApp(ICliWorkflow workflow, ICliIo io) : CliApp(workflow, io);