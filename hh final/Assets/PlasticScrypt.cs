using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlasticScrypt : MonoBehaviour
{
	public GameObject plasticText;
	public static int theScore;
	void Start()
	{
		theScore = 0;
	}
	void Update()
	{
		plasticText.GetComponent<Text>().text = "PLASTIC: " + theScore;
	}

}
