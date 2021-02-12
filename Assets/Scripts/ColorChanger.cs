using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
     
    public Dropdown colorDropdown;

    public GameObject player;

    // Update is called once per frame
    public void colorchange()
    {
        switch (colorDropdown.value)
        {
            case 0:
                player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 1:
                player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                player.GetComponent<Renderer>().material.color = Color.yellow;
                break;
        }
    }
}
