using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class container : MonoBehaviour
{

    [SerializeField]
    private string collectTag;

    [SerializeField]
    private gameManager game;

    private SpriteRenderer spriteBoy;

    public Color color1;
    public Color color2;

    private void Start()
    {
        spriteBoy = GetComponent<SpriteRenderer>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //this hurts my eyes it is so messy I want to cry

        if (collectTag == "recycle" && collision.gameObject.GetComponent<Draggable>().yucky == true)
        {
            wrongItem();
            Destroy(collision.gameObject);
        }

        else if(collectTag == "trash" && collision.gameObject.tag == "compost")
        {
            game.increaseScore(1);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == collectTag)
        {
            game.increaseScore(1);
            if(collision.gameObject.tag == "compost")
            {
                game.increaseScore(1);
            }
            Destroy(collision.gameObject);
        }

        else
        {
            wrongItem();
            Destroy(collision.gameObject);
        }
    }

    private void wrongItem()
    {
        game.increaseScore(-1);
        game.loseLives(1);
    }

    public void openContainer()
    {
        spriteBoy.color = color2;
    }

    public void closeContainer()
    {
        spriteBoy.color = color1;
    }

}
