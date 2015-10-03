using UnityEngine;
using System.Collections;

public class Tile {
	public enum type{
		Ground,
		Mech,
		Source
	};
	public enum color{
		Red,
		Green,
		Blue
	}
	private bool isEnabled;
	public bool IsEnabled{
		get{
			return isEnabled;
		}

		set{
			isEnabled = value;

		}
	}

}
