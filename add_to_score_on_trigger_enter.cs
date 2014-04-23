using UnityEngine;
using System.Collections;

public class add_to_score_on_trigger_enter : MonoBehaviour 
{
	public int score_value = 100;
	public ScoreManager score_manager_value;

	void Start()
	{
		GameObject score_manager_object = GameObject.FindWithTag("ScoreManager");
		if(score_manager_object != null)
		{
			score_manager_value = score_manager_object.GetComponent<ScoreManager>();
		}
		if (score_manager_value == null)
		{
			Debug.Log ("Cannot find 'ScoreManager");
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			score_manager_value.AddScore (score_value);	
		}
	}
}
