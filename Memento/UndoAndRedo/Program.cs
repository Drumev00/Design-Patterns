using UndoAndRedo;

var acc = new BankAccount(100);
acc.Deposit(50);
acc.Deposit(25);
Console.WriteLine(acc);

acc.Undo();
Console.WriteLine($"Undo 1: {acc}");
acc.Undo();
Console.WriteLine($"Undo 2: {acc}");
acc.Redo();
Console.WriteLine($"Redo: {acc}");