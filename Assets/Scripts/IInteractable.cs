namespace Labirint
{
    public interface IInteractable : IAction
    {
        bool IsInteractable { get; }
    }
}