using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform parent;
    void Start()
    {
        transform.SetParent(parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
