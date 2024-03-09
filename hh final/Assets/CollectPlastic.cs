using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPlastic : MonoBehaviour
{
	public AudioSource collectSound;
	    
	void OnTriggerEnter(Collider other)
	{
		collectSound.Play();
		PlasticScrypt.theScore += 1;
		Destroy(gameObject);
	}
}
