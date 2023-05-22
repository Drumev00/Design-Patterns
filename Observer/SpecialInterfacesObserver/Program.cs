using SpecialInterfacesObserver;

var person = new Person();
var friend = new Friend();
IDisposable subscription = person.Subscribe(friend);
person.FallIll();
