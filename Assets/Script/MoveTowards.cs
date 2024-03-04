using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public Vector3 destination;
    public float speed= 0.01f;

    // Update is called once per frame
    void Update()
    {
        if (destination == null) return;
        transform.position = Vector3.MoveTowards(transform.position, destination, speed);
        if (transform.position == destination) this.enabled = false;
    }
}
