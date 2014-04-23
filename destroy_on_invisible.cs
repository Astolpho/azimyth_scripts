using UnityEngine;
using System.Collections;

public class destroy_on_invisible : MonoBehaviour
{
	public bool destroy_self = true;
	public GameObject[] destroy_objects;

	void OnBecameInvisible()
	{
		if(destroy_self)
		{
			Destroy(gameObject);	
		}
		foreach(GameObject obj in destroy_objects)
		{
			Destroy(obj);
		}
	}
}
