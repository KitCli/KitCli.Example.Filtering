using KitCli.Commands.Abstractions;
using KitCli.Commands.Abstractions.Artefacts;
using KitCli.Commands.Abstractions.Factories;
using KitCli.Instructions.Abstractions;
using KitCli.Instructions.Arguments;

public class FilterJobRoleOnJobRoleIdCliCommandFactory : ICliCommandFactory<FilterCliCommand>
{
    public bool CanCreateWhen(CliInstruction instruction, List<CliCommandArtefact> artefacts)
    {
        var previouslyCalledSomethingCommand = artefacts.LastCommandRanWas<JobRoleCliCommand>();

        var calledFilterOnSubCommand = instruction.SubInstructionName == FilterCliCommand.SubCommandNames.FilterOn;
        
        return previouslyCalledSomethingCommand && calledFilterOnSubCommand;
    }

    public CliCommand Create(CliInstruction instruction, List<CliCommandArtefact> artefacts)
    {
        var somethingAggregatorArtefact = artefacts
            .OfListAggregatorType<JobRoleAggregate>();
        
        var categoryIdArgument = instruction
            .Arguments
            .OfRequiredType<int>(FilterJobRoleOnJobRoleIdCliCommand.ArgumentNames.JobRoleId);
        
        return new FilterJobRoleOnJobRoleIdCliCommand(
            somethingAggregatorArtefact!.ArtefactValue,
            categoryIdArgument.ArgumentValue);
    }
}