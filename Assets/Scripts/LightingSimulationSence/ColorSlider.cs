using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSlider : MonoBehaviour
{
    [SerializeField] GameObject LightGroup;
    
    public Slider sliderRed;
    public Slider sliderGreen;
    public Slider sliderBlue;

    public Slider sliderBrightness;


    // Start is called before the first frame update
    void Start()
    {
        //sliderBrightness = sliderObject.GetComponent<Slider>();
        sliderRed.value = 0.7f;
        sliderGreen.value = 0.5f;
        sliderBlue.value = 0.3f;
        sliderBrightness.value = 4;
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
        foreach (Transform childTransform in LightGroup.transform)
        {
            childTransform.GetComponent<Light>().color = new Color(red, green, blue, 1);
        }
    }

    public void BrightnessValueChange()
    {
        foreach (Transform childTransform in LightGroup.transform)
        {
            childTransform.GetComponent<Light>().intensity = sliderBrightness.value;
        }
    }
}
