using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Speed : MonoBehaviour
{
    Text speedValue;

    public Slider mySlider;

    private void Start()
    {
        speedValue = GetComponent<Text>();
    }

    // Update is called once per frame
    public void textUpdate(float value)
    {
        speedValue.text = "SPEED: " +  Mathf.RoundToInt(value).ToString();
    }

    public void speedUpdate(float value)
    {
         PlayerController.speed = mySlider.value;
        //PlayerPrefs.SetFloat("speed", PlayerController.speed);
    }
}
