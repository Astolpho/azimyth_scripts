using UnityEngine;
using System.Collections;

public class camer_follow : MonoBehaviour 
{
	public Transform object_to_follow;
	public Vector2 movement_ratio = Vector2.one;
	// Use this for initialization
	void Start () 
	{
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 new_position = object_to_follow.position;
		new_position.x *=movement_ratio.x;
		new_position.y *= movement_ratio.y;
		new_position.z = transform.position.z;
		transform.position = new_position;
	}
}
