using FluentBuilder;

var me = Person.New.Called("Alexander").WorksAs(".NET Developer").Build();
Console.WriteLine(me);