using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    public float vel;

    public void Stop()
    {
        Destroy(this);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float newX = transform.position.x + vel * Time.fixedDeltaTime;
        transform.position = new Vector2(newX, transform.position.y);
    }
}
