using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class playerController : MonoBehaviour
{
    public float speed = 4.5f;
    public float jumpForce = 12.0f;
    private Rigidbody2D body;
    private BoxCollider2D box;
    private float disToGround;
    private Vector3 startRay;
    public bool onLadder;
    // Start is called before the first frame update
    void Start()
    {
        startRay = transform.position;
        box = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();
        disToGround = box.bounds.extents.y;
    }
    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        if (!onLadder){
            deltaZ = body.velocity.y;
        }
        Vector2 Movement = new Vector2(deltaX, deltaZ);

        disToGround = box.bounds.extents.y;
        body.velocity = Movement;

        startRay = transform.position;
        startRay.y += -disToGround- 0.1f;

        if(Input.GetKeyDown(KeyCode.Space) && Physics2D.Raycast(startRay, transform.TransformDirection(-Vector3.up), 0.2f)){
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    public void changeSize(Vector3 size){
        transform.localScale = size;
    }
}
