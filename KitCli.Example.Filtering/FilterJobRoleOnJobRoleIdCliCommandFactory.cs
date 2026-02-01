using KitCli.Commands.Abstractions;
using KitCli.Commands.Abstractions.Artefacts;
using KitCli.Commands.Abstractions.Factories;
using KitCli.Instructions.Abstractions;
using KitCli.Instructions.Arguments;

public class FilterJobRoleOnJobRoleIdCliCommandFactory : ICliCommandFactory<FilterCliCommand>
{
    public bool CanCreateWhen(CliInstruction instruction, List<CliCommandArtefact> artefacts)
    {
        var afterJobRoleCommand = artefacts.LastCommandRanWas<JobRoleCliCommand>();

        var filteringOn = instruction.SubInstructionName == FilterCliCommand.SubCommandNames.FilterOn;
        
        return afterJobRoleCommand && filteringOn;
    }

    public CliCommand Create(CliInstruction instruction, List<CliCommandArtefact> artefacts)
    {
        var aggregatorArtefact = artefacts
            .OfListAggregatorType<JobRoleAggregate>();
        
        var jobRoleIdArgument = instruction
            .Arguments
            .OfRequiredType<int>(FilterJobRoleOnJobRoleIdCliCommand.ArgumentNames.JobRoleId);
        
        return new FilterJobRoleOnJobRoleIdCliCommand(
            aggregatorArtefact!.ArtefactValue,
            jobRoleIdArgument.ArgumentValue);
    }
}