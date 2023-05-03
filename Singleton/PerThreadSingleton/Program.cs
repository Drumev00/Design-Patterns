using PerThreadSingleton;

var thread1 = Task.Factory.StartNew(() =>
{
	Console.WriteLine($"t1: {PerThreadSingleton.PerThreadSingleton.ThreadInstance.Id}");
});

var thread2 = Task.Factory.StartNew(() =>
{
	Console.WriteLine($"t2: {PerThreadSingleton.PerThreadSingleton.ThreadInstance.Id}");
	Console.WriteLine($"t2: {PerThreadSingleton.PerThreadSingleton.ThreadInstance.Id}");
});
Task.WaitAll(thread1, thread2);