using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperScrypt : MonoBehaviour
{
	public GameObject paperText;
	public static int theScore;
	void Start()
	{
		theScore = 0;
	}
	void Update()
	{
		paperText.GetComponent<Text>().text = "PAPERS: " + theScore;
	}

}
