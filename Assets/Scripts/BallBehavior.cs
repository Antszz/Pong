using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public Transform paddle;
    private Rigidbody2D rbBall;
    public bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!start)
        {
            Vector3 aux = paddle.position;
            aux.x += 0.5f;
            transform.position = aux;
            if (Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8,8);
                start = true;
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
