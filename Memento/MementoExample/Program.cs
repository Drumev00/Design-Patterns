using MementoExample;

var acc = new BankAccount(100);
var m1 = acc.Deposit(50); // 150
var m2 = acc.Deposit(25); // 175

Console.WriteLine(acc);

acc.Restore(m1);
Console.WriteLine(acc);
acc.Restore(m2);
Console.WriteLine(acc);