using KitCli.Commands.Abstractions;

public record FilterCliCommand : CliCommand
{
    public static class SubCommandNames
    {
        public const string FilterOn = "on";
    }
}