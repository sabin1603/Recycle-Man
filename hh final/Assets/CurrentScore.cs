using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
	public GameObject currentScore;
	public static int theScore;

	void Update()
	{
		currentScore.GetComponent<Text>().text = "SCORE: " + ScoringScrypt.theScore;
	}
}