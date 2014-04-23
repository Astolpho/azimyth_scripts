using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour
{
	public float movement_speed = 1.0f;
	public int invert = -1; //negative 1 for invert, positive 1 for not inverted

	
	// Update is called once per frame
	void Update () 
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 direction = new Vector3(horizontal, invert*vertical,0);
		Vector3 final_direction = new Vector3(horizontal, invert*vertical, 5.0f);

		transform.position += direction*movement_speed*Time.deltaTime;
		transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(final_direction),Mathf.Deg2Rad*50.0f);

	}
}
