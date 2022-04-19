using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropletSpawner : MonoBehaviour
{
    public float spawnTime, despawnTime, xForce, yForce;
    public bool spawnEnabled;
    public GameObject droplet;
    void Start()
    {
        spawnEnabled = false;
        StartCoroutine(spawnDroplet());
    }

    IEnumerator spawnDroplet()
    {
        while(true)
        {
            while(spawnEnabled)
            {
                GameObject drop = Instantiate(droplet, transform.position, transform.rotation);
                drop.GetComponent<Rigidbody2D>().AddForce((Vector2.right * Random.Range(-xForce, xForce) + Vector2.down * Random.Range(0, yForce)), ForceMode2D.Impulse); //Random.Range(-xForce, xForce), 
                yield return new WaitForSeconds(spawnTime);
            }

            yield return new WaitForSeconds(spawnTime);

        }

    }

    public void turnOn()
    {
        spawnEnabled = true;
    }

    public void turnOff()
    {
        spawnEnabled = false;
    }    
}
