using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public void openAmazon()
    {
        Application.OpenURL("https://www.amazon.in/Atomic-Habits-James-Clear/dp/1847941834");
        print("Code running");
    }

    public void openKindle()
    {
        Application.OpenURL("https://read.amazon.in/landing");
    }
    public void openAudible()
    {
        Application.OpenURL("https://www.audible.in/pd/Atomic-Habits-Audiobook/B07J1PK5Q7");
    }
    public void openFLipkart()
    {
        Application.OpenURL("https://dl.flipkart.com/s/qvP0QdNNNNl");
    }
}
