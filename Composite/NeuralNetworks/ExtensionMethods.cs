namespace NeuralNetworks
{
	internal static class ExtensionMethods
	{
		public static void ConnectTo(this IEnumerable<Neuron> slef, IEnumerable<Neuron> other)
		{
			if (ReferenceEquals(slef, other)) return;

			foreach (Neuron from in slef)
			{
				foreach (Neuron to in other)
				{
					from.Out.Add(to);
					to.In.Add(from);
				}
			}
		}
	}
}
