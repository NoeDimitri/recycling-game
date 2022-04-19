using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropCollider : MonoBehaviour
{
    [SerializeField]
    private container bin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Draggable touchingPart = collision.gameObject.GetComponent<Draggable>();
        if (touchingPart != null)
        {
            bin.openContainer();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Draggable touchingPart = collision.gameObject.GetComponent<Draggable>();
        if (touchingPart != null)
        {
            bin.closeContainer();
        }
    }
}
