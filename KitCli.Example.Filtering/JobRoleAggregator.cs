using KitCli.Abstractions.Aggregators;
using KitCli.Example.Filtering;

public class JobRoleAggregator(IEnumerable<Person> people) : CliListAggregator<JobRoleAggregate>
{
    private readonly List<Func<IEnumerable<Person>, IEnumerable<Person>>> peopleOperationFunctions = [];

    protected override IEnumerable<JobRoleAggregate> ListAggregate()
    {
        var operatedOnSource = people;
        
        foreach (var func in peopleOperationFunctions)
        {
            operatedOnSource = func(operatedOnSource);
        }
        
        return operatedOnSource
            .GroupBy(x => x.JobRoleId)
            .Select(g => new JobRoleAggregate
            {
                JobRoleId = g.Key,
                Count = g.Count()
            });
    }
    
    public JobRoleAggregator BeforeAggregation(Func<IEnumerable<Person>, IEnumerable<Person>> func)
    {
        peopleOperationFunctions.Add(func);
        return this;
    }
}