using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour 
{
	public Rigidbody bullet;
	public float bullet_velocity = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Rigidbody new_bullet = Instantiate(bullet,transform.position,transform.rotation) as Rigidbody;
			new_bullet.AddForce(transform.forward*bullet_velocity,ForceMode.VelocityChange);
		}
	}
}
