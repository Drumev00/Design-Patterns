using PrototypeInheritance.Abstractions;

namespace PrototypeInheritance
{
	internal class Employee : Person, IDeepCopyable<Employee>
	{
		public int Salary { get; set; }

		public Employee()
		{

		}

		public Employee(string[] names, Address address, int salary): base(names, address)
		{
			Salary = salary;
		}

		public override string ToString()
		{
			return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
		}

		public void CopyTo(Employee target)
		{
			// copying FROM the base class to this one, allowing us to only populate members of this class
			base.CopyTo(target);
			target.Salary = Salary;
		}
	}
}
