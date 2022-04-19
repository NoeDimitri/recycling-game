using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterTrigger : MonoBehaviour
{
    public dropletSpawner dropper;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "droplet")
        {
            dropper.turnOn();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "droplet")
        {
            dropper.turnOff();
        }
    }

   
}
