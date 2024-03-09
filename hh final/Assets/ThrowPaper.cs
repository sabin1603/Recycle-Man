using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPaper : MonoBehaviour
{
	public AudioSource collectSound;
	    
	void OnTriggerEnter(Collider other)
	{
		collectSound.Play();
		ScoringScrypt.theScore += PaperScrypt.theScore * 5;
		PaperScrypt.theScore = 0;
	}
}
