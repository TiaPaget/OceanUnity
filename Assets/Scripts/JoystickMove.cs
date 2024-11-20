using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    public Joystick movementJoystick;
    public float playerSpeed;
    public float dampingFactor = 0.95f; //"slide" effect
    public float bouyancyForce = 1.0f;
    private Rigidbody2D rb;
    public MenuLoader menuLoader;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (movementJoystick.Direction.y != 0)
        {
            rb.velocity = new Vector2(movementJoystick.Direction.x * playerSpeed, movementJoystick.Direction.y * playerSpeed);
        }
        else
        {
            rb.velocity *= dampingFactor;
            rb.AddForce(Vector2.up * bouyancyForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("LADDER TRIGGER");
        if (menuLoader != null)
        {
            menuLoader.openMenu();
        }
    }
}
