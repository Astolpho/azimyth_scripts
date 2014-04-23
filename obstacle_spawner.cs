using UnityEngine;
using System.Collections;

public class obstacle_spawner : MonoBehaviour 
{
	public GameObject [] spawn_object;
	public float x_range = 1.0f;
	public float y_range = 1.0f;
	public float min_spawn_time = 1.0f;
	public float max_spawn_time = 10.0f;
	// Use this for initialization
	void Start ()
	{
		Invoke("SpawnWall", Random.Range(min_spawn_time, max_spawn_time));	
	}
	
	// Update is called once per frame
	void SpawnWall ()
	{
		float x_offset = Random.Range(-x_range, x_range);
		float y_offset = Random.Range(-y_range, y_range);
		int spawn_object_index = Random.Range(0,spawn_object.Length);
		Instantiate(spawn_object[spawn_object_index],transform.position + new Vector3(x_offset, y_offset, 0.0f), spawn_object[spawn_object_index].transform.rotation);
		Invoke("SpawnWall", Random.Range(min_spawn_time, max_spawn_time));	
	}
}
