using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 4.5f;

    public float jumpForce = 12.0f;


    private Rigidbody2D body;
    private BoxCollider2D box;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        Vector2 Movement = new Vector2(deltaX, body.velocity.y);
        body.velocity = Movement;

        Vector3 max = box.bounds.max;
        Vector3 min = box.bounds.min;
        Vector2 corner1 = new Vector2(max.x, min.y - 0.1f);
        Vector2 corner2 = new Vector2(min.x, min.y - 0.2f);
        Collider2D hit = Physics2D.OverlapArea(corner1, corner2);

        bool grounded = false;

        if(hit != null){
            grounded = true;
        }

        if(grounded && Input.GetKeyDown(KeyCode.Space)){
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
