﻿using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Prototype
{
	internal static class ExtensionMethods
	{
		// binary formatter is obsolete actually..
		public static T DeepCopy<T>(this T self)
		{
			var stream = new MemoryStream();
			var formatter = new BinaryFormatter();
			formatter.Serialize(stream, self);
			stream.Seek(0, SeekOrigin.Begin);

			object copy = formatter.Deserialize(stream);
			stream.Close();

			return (T)copy;
		}

		public static T DeepCopyXml<T>(this T self)
		{
			using (var stream = new MemoryStream())
			{
				var serializer = new XmlSerializer(typeof(T));
				serializer.Serialize(stream, self);
				stream.Position = 0;

				return (T)serializer.Deserialize(stream);
			}

		}
	}
}
