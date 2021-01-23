using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSlider : MonoBehaviour
{
    [SerializeField] GameObject LightGroup1;
    
    public Slider sliderRed;
    public Slider sliderGreen;
    public Slider sliderBlue;

    public GameObject sliderObject;
    Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        slider = sliderObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ValueChange()
    {
        float red = sliderRed.value;
        float green = sliderGreen.value;
        float blue = sliderBlue.value;
        foreach (Transform childTransform in LightGroup1.transform)
        {
            childTransform.GetComponent<Light>().color = new Color(red, green, blue, 1);
        }
    }

    public void BrightnessValueChange()
    {
        foreach (Transform childTransform in LightGroup1.transform)
        {
            childTransform.GetComponent<Light>().intensity = slider.value;
        }
    }
}
