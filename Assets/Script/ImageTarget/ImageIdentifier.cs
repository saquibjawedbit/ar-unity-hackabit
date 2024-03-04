using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageIdentifier : MonoBehaviour
{


    public GameObject ui;
    public void OnImageTracked()
    {
        ui.SetActive(true);
    }

    public void onTargetLost()
    {
        ui.SetActive(false);
    }
}
