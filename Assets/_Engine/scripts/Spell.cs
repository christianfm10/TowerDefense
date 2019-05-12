using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public int impact;
    public GameObject impactParticleEffect;
    public float radiusEffect;

    public int manaCost;

    // Start is called before the first frame update
    void OnEnable()
    {
        GameObject particle = Instantiate(impactParticleEffect, transform.position, Quaternion.identity) as GameObject;
        Destroy(particle, 2);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(" Colision detectada con " + other.gameObject.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<Enemy>().damage(-impact);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
