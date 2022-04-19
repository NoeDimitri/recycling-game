using UnityEngine;

public class Draggable : MonoBehaviour
{
    private Camera myCam;
    private float startXPos;
    private float startYPos;
    private bool isDragging = false;
    private Rigidbody2D rb;

    public Color color1;
    private SpriteRenderer spriteBoy;
    [SerializeField] public bool yucky;
    [SerializeField] int scrubNum;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "droplet")
        {
            scrubNum -= 1;
        }

        Transform yuckers = transform.Find("ew");

        if(yuckers != null && scrubNum <= 0)
        {
            yuckers.gameObject.SetActive(false);
            yucky = false;
        }

        
    }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        myCam = GameObject.Find("Main Camera").GetComponent<Camera>();

        spriteBoy = gameObject.GetComponent<SpriteRenderer>();
        spriteBoy.color = color1;
   }

    private void Update()
    {
        if (isDragging)
        {
            DragObject();
        }

    }
    private void OnMouseDown()
    {
        Vector3 mousePos = Input.mousePosition;
        rb.freezeRotation = true;


        if (!myCam.orthographic)
        {
            mousePos.z = 10;
        }

        mousePos = myCam.ScreenToWorldPoint(mousePos);

        startXPos = mousePos.x - transform.localPosition.x;
        startYPos = mousePos.y - transform.localPosition.y;

        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;
        rb.velocity = new Vector3(0, 0);

        rb.freezeRotation = false;
    }

    public void DragObject()
    {
        Vector3 mousePos = Input.mousePosition;

        if (!myCam.orthographic)
        {
            mousePos.z = 10;
        }

        mousePos = myCam.ScreenToWorldPoint(mousePos);
        transform.localPosition = new Vector3(mousePos.x - startXPos, mousePos.y - startYPos, transform.localPosition.z);
    }
}