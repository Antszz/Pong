using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;
    private BallBehavior ballBehavior;
    public float speed;
    private int dir;
    private void Start()
    {
        ballBehavior = ball.GetComponent<BallBehavior>();
    }
    // Update is called once per frame
    void Update()
    {
        if (ballBehavior.start)
        {
            if (ball.transform.position.y < transform.position.y)
                dir = -1;
            else
                dir = 1;

            transform.position = new Vector3(
                transform.position.x, 
                Mathf.Clamp(
                    transform.position.y + speed * Time.deltaTime * dir
                    , -3.75f, 3.75f)
                , 0);
        }
    }
}
