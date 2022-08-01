using Spectre.Console;
using Spectre.Console.Cli;

var app = new CommandApp();
app.Configure(c =>
{
    c.AddCommand<SendNormalizedRecordToLime>("send");
    c.AddCommand<NormalizeLimeCsvCommand>("normalize");
});
return app.Run(args);

internal abstract class BaseCommand : Command
{
    public override int Execute(CommandContext context)
    {
        AnsiConsole.MarkupLine($"Hello from [green]{GetType().Name}[/].");

        return 0;
    }
}

internal sealed class SendNormalizedRecordToLime : BaseCommand
{
}

internal sealed class NormalizeLimeCsvCommand : BaseCommand
{
}