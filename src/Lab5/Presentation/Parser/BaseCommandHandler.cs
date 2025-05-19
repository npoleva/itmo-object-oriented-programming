namespace Presentation.Parser;

public abstract class BaseCommandHandler : ICommandHandler
{
    private ICommandHandler? _nextSuccessor;

    public ICommandHandler SetNext(ICommandHandler successor)
    {
        _nextSuccessor = successor;

        return successor;
    }

    public virtual void HandleRequest(string selection)
    {
        _nextSuccessor?.HandleRequest(selection);
    }
}