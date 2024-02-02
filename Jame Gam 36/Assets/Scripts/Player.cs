using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();

    }
    public float speed;
    Rigidbody2D body;

    float horizontal;
    float vertical;
    SpriteRenderer sprite;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (horizontal < 0)
        {
            sprite.flipX = true;
        } else if (horizontal > 0)
        {
            sprite.flipX = false;
        }
    }
    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal, vertical).normalized * speed;
    }
}
