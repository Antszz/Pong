using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        mousePosition.x = transform.position.x;
        mousePosition.y = Mathf.Clamp(mousePosition.y, -3.75f, 3.75f);
        transform.position = mousePosition; 
    }
}
