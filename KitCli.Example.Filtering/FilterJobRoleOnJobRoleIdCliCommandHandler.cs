using KitCli.Abstractions.Aggregators.Filters;
using KitCli.Abstractions.Tables;
using KitCli.Commands.Abstractions.Handlers;
using KitCli.Commands.Abstractions.Outcomes;
using KitCli.Commands.Abstractions.Outcomes.Final;

public class FilterJobRoleOnJobRoleIdCliCommandHandler : CliCommandHandler, ICliCommandHandler<FilterJobRoleOnJobRoleIdCliCommand>
{
    public Task<CliCommandOutcome[]> Handle(FilterJobRoleOnJobRoleIdCliCommand command, CancellationToken cancellationToken)
    {
        var jobRoleAggregator = command.Aggregator as JobRoleAggregator;
        
        jobRoleAggregator.BeforeAggregation(
            people => people.Where(person => person.JobRoleId == command.JobRoleId));

        var filter = new ValuedCliListAggregatorFilter<int>(
            FilterJobRoleCliCommand.FilterNames.JobRoleId,
            nameof(FilterJobRoleOnJobRoleIdCliCommand.JobRoleId),
            command.JobRoleId);
        
        var table = new CliTable
        {
            ShowRowCount = false,
            Columns = ["Job Role ID", "Count"]
        };
        
        foreach (var aggregate in jobRoleAggregator.Aggregate())
        {
            table.Rows.Add([
                aggregate.JobRoleId.ToString(),
                aggregate.Count.ToString()
            ]);
        }
        
        var outcomes = new List<CliCommandOutcome>
        {
            new FilterCliCommandOutcome(filter),
            new CliCommandTableOutcome(table),
        };
        
        return Task.FromResult(outcomes.ToArray());
    }
}