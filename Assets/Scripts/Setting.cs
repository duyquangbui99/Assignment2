using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{

    public static bool oversizedBall;
    public Text output;

    public Dropdown matterialDropdown;
    public Toggle oversizedBallToggle;


    public void BigBall(bool newValue)
    {
        oversizedBall = newValue;
    }



    public void changeColor()
    {
        switch (matterialDropdown.value)
        {
            case 0:
                output.text = "Color: Red";
                break;
            case 1:
                output.text = "Color: Blue";
                break;
            case 2:
                output.text = "Color: Yellow";
                break;
        }
    }
}
