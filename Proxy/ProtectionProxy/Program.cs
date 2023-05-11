using ProtectionProxy;
using ProtectionProxy.Abstractions;

ICar car = new CarProxy(new Driver(22));
car.Drive();
