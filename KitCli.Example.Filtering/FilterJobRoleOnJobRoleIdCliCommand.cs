using KitCli.Abstractions.Aggregators;
using KitCli.Commands.Abstractions;

public record FilterJobRoleOnJobRoleIdCliCommand(CliListAggregator<JobRoleAggregate> Aggregator, int JobRoleId) : CliCommand
{
    public static class ArgumentNames
    {
        public const string JobRoleId = "job-role-id";
    }
}