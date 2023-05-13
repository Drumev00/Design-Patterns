namespace UndoOperations.Abstractions
{
	internal interface ICommand
	{
		void Call();
		void Undo();
	}
}
