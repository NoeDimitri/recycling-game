using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private gameManager game;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "trash")
        {
            game.loseLives(1);
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "droplet")
        {
            Destroy(collision.gameObject);
        }
    }
}
