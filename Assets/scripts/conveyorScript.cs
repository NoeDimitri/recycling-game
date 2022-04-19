using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyorScript : MonoBehaviour
{
    [SerializeField]
    private float conveyorSpeed = 2;



    private void OnCollisionStay2D(Collision2D collision)
    {

        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.velocity = new Vector3(conveyorSpeed, rb.velocity.y);
        }
    }


}
