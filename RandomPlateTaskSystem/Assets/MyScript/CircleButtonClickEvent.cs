using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleButtonClickEvent : MonoBehaviour
{
    public void SelectOn()
    {
        this.GetComponent<Image>().enabled = true;
    }
    public void SelectOff()
    {
        this.GetComponent<Image>().enabled = false;
    }
}
