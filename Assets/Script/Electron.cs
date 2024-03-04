using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform nucleus;
    [SerializeField] private float rotationSpeed = 5;
    void Start()
    {
       // nucleus = GetComponentInParent<Transform>();
       // print(nucleus.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(nucleus.position, transform.up, rotationSpeed * Time.deltaTime);
    }
}
