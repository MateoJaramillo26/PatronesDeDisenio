using System;
using System.Collections.Generic;
using Vehicle;

public class MemoryCollection
{

	private static MemoryCollection _instance;
	public ICollection<Vehicles> Vehicles { get; set; }
	public MemoryCollection()
	{
		Vehicles = new List<Vehicles>();
	}
	public static MemoryCollection Instance
	{
		get
		{
			if (_instance == null)
				_instance = new MemoryCollection()
			return _instance;
		}
	}
}