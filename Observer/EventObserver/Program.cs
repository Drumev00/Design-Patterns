using EventObserver;

var person = new Person();

// subscription
person.FallsIll += CallDoctor;

person.CatchCold();

// unsubscribe
//person.FallsIll -= CallDoctor;

// handler
static void CallDoctor(object sender, FallsIllEventArgs args)
{
	Console.WriteLine($"A doctor has been called to {args.Address}");
}