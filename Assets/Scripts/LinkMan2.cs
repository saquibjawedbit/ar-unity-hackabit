using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkMan2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void openAmazon()
    {
        Application.OpenURL("https://www.amazon.in/How-Win-Friends-Influence-People/dp/8194790891/ref=pd_lpo_sccl_2/260-7125306-7098532?pd_rd_w=8j1ij&content-id=amzn1.sym.646ecf30-bd56-461f-a4dc-7f0c041d20b3&pf_rd_p=646ecf30-bd56-461f-a4dc-7f0c041d20b3&pf_rd_r=193Y0ZSR85K9XPMRCM3R&pd_rd_wg=jKJrl&pd_rd_r=a4abd97b-395a-4d32-b336-c9315d6f691d&pd_rd_i=8194790891&psc=1");
    }

    public void openKindle()
    {
        Application.OpenURL("https://read.amazon.in/landing");
    }
    public void openAudible()
    {
        Application.OpenURL("https://www.audible.in/pd/How-to-Win-Friends-and-Influence-People-Audiobook/B07K4VNF8P");
    }
    public void openFLipkart()
    {
        Application.OpenURL("https://www.flipkart.com/win-friends-influence-people/p/itm497659806d0e9");
    }

}
