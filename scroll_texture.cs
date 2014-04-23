using UnityEngine;
using System.Collections;

public class scroll_texture : MonoBehaviour 
{
	public Vector2 scroll_speed = Vector2.one;
	private Material mat;
	// Use this for initialization
	void Start ()
	{
		mat = renderer.material;
	}
	
	// Update is called once per frame
	void Update ()
	{
		mat.mainTextureOffset += scroll_speed*Time.deltaTime;
	}
}
