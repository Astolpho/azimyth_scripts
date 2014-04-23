using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour 
{
	public GUIText scoreText;

	private int score;

	void Start()
	{
			score = 0;
			UpdateScore ();
	}


	public void AddScore (int new_score_value)
	{
		score += new_score_value;
		UpdateScore();
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}
}
