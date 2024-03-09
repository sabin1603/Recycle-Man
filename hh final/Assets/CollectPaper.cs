using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPaper : MonoBehaviour
{
	public AudioSource collectSound;
	    
	void OnTriggerEnter(Collider other)
	{
		collectSound.Play();
		PaperScrypt.theScore += 1;
		Destroy(gameObject);
	}
}
