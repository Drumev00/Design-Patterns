using ChatRoom;

var chat = new ChatRoom.ChatRoom();

var john = new Person("John");
var jane = new Person("Jane");

chat.Join(john);
chat.Join(jane);

john.Say("hi");
jane.Say("oh, hey");

var simon = new Person("Simon");
chat.Join(simon);
simon.Say("hi everyone");
john.PrivateMessage("Simon", "glad you joined us");
