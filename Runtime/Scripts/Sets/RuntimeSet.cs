using System.Collections.Generic;
using UnityEngine;

namespace aburron.abutoolkit.Sets
{
	public abstract class RuntimeSet<T> : ScriptableObject
	{
		[SerializeField] private List<T> items = new List<T>();

		public List<T> Items => items;
		
		public int Count => items.Count;

		public T IndexOf(int i) => items[i];

		public void TryAdd(T item)
		{
			if (!items.Contains(item))
				Add(item);
		}

		public void TryRemove(T item)
		{
			if (items.Contains(item))
				Remove(item);
		}

		public void Add(T item) => items.Add(item);

		public void Remove(T item) => items.Remove(item);

		public void Clear() => items.Clear();
	}
}