using UnityEngine;
using System.Collections;

public class destroy_by_time : MonoBehaviour 
{

	public float lifetime;

	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
