using KitCli.Abstractions.Tables;
using KitCli.Commands.Abstractions.Handlers;
using KitCli.Commands.Abstractions.Outcomes;
using KitCli.Commands.Abstractions.Outcomes.Final;
using KitCli.Commands.Abstractions.Outcomes.Reusable;
using KitCli.Example.Filtering;

public class JobRoleCliCommandHandler : CliCommandHandler, ICliCommandHandler<JobRoleCliCommand>
{
    public Task<CliCommandOutcome[]> Handle(JobRoleCliCommand command, CancellationToken cancellationToken)
    {
        var aggregator = new JobRoleAggregator(People.All);
        
        var table = new CliTable();
        table.ShowRowCount = false;
        table.Columns.AddRange("Job Role ID", "Count");
        
        foreach (var aggregate in aggregator.Aggregate())
        {
            table.Rows.Add([
                aggregate.JobRoleId.ToString(),
                aggregate.Count.ToString()
            ]);
        }
        
        var outcomes = new CliCommandOutcome[]
        {
            new CliCommandTableOutcome(table),
            new ListAggregatorCliCommandOutcome<JobRoleAggregate>(aggregator)
        };
        
        return Task.FromResult(outcomes);
    }
}