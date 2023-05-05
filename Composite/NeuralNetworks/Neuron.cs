using System.Collections;

namespace NeuralNetworks
{
	internal class Neuron : IEnumerable<Neuron>
	{
		public float Value { get; set; }

		public List<Neuron> In { get; set; }

		public List<Neuron> Out { get; set; }

		public IEnumerator<Neuron> GetEnumerator()
		{
			yield return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
