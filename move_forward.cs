using UnityEngine;
using System.Collections;

public class move_forward : MonoBehaviour 
{
	public float scene_speed = 1.0f;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += transform.forward*scene_speed*Time.deltaTime;	
	}
}
