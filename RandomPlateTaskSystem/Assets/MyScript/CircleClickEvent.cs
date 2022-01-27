using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleClickEvent : MonoBehaviour
{
    public void ClickOn()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
