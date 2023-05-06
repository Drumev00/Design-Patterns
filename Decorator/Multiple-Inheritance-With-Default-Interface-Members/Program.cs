using Multiple_Inheritance_With_Default_Interface_Members;
using Multiple_Inheritance_With_Default_Interface_Members.Abstractions;

Dragon dragon = new Dragon { Age = 5 };

// doesn't work v

//dragon.Crawl();
//dragon.Fly();

// works -> ((ILizard)dragon).Crawl();

if (dragon is IBird bird)
	bird.Fly();

if (dragon is ILizard lizard)
	lizard.Crawl();



