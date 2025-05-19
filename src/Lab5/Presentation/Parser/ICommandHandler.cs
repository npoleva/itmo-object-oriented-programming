namespace Presentation.Parser;

public interface ICommandHandler
{
    public ICommandHandler SetNext(ICommandHandler successor);

    public abstract void HandleRequest(string selection);
}