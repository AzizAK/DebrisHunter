using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public ParticleSystem DestructionEffect;
    public static Destroyer instance;
    // Use this for initialization
    void Start () {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("this collider is destroyed" + other.name);
        if (other.name == "Earth")
            return;
        Explode(other.gameObject, DestructionEffect);
        //Destroy(other);
    }

    public void Explode(GameObject gameObject, ParticleSystem effect )
    {
        if (gameObject.name == "Earth")
            return;
        Debug.Log("----------explode");
        //Instantiate our one-off particle system
        ParticleSystem explosionEffect = Instantiate(effect)
                                         as ParticleSystem;
        explosionEffect.transform.position = gameObject.transform.position;
        //play it
        //explosionEffect.main.loop = false;
        explosionEffect.Play();

        //destroy the particle system when its duration is up, right
        //it would play a second time.
        Destroy(explosionEffect.gameObject, explosionEffect.main.duration);
        //destroy our game object
        Destroy(gameObject);

    }
}
