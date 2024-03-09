using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPlastic : MonoBehaviour
{
	public AudioSource collectSound;
	    
	void OnTriggerEnter(Collider other)
	{
		collectSound.Play();
		ScoringScrypt.theScore += PlasticScrypt.theScore * 10;
		PlasticScrypt.theScore = 0;
	}
}
