using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderBar : MonoBehaviour
{
    float valueTime;
    public GameObject slider;

    void Start()
    {
        valueTime = 5;
        slider.GetComponent<Slider>().value = 5;
        StartCoroutine("TimeSlider");
    }

    IEnumerator TimeSlider()
    {        
        while (valueTime >= 0)
        {
            valueTime -= Time.deltaTime;
            slider.GetComponent<Slider>().value = valueTime;
            yield return null;
        }
        SceneManager.LoadScene("MainScene");
    }
}
