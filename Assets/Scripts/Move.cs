using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * -(jumpForce), ForceMode.Impulse);
        }

        rb.velocity = new Vector3(moveForce, rb.velocity.y, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Goal")
        {
            SceneManager.LoadScene("LevelEnd");
        }
        if (collision.collider.tag == "Obsticle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
