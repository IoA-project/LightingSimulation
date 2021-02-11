using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSlider : MonoBehaviour
{
    [SerializeField] GameObject LightGroup;
    public Slider sliderBrightness;

    // Start is called before the first frame update
    void Start()
    {
        //sliderBrightness = sliderObject.GetComponent<Slider>();
        sliderBrightness.value = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BrightnessValueChange()
    {
        foreach (Transform childTransform in LightGroup.transform)
        {
            childTransform.GetComponent<Light>().intensity = sliderBrightness.value;
        }
    }
}
