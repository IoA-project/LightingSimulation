using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider2 : MonoBehaviour
{
    [SerializeField] GameObject ChangeLight;
    [SerializeField] GameObject sliderObject;
    Slider slider;
    
    const int IntensityMin = 0;
    const int IntensityMax = 50;

    // Start is called before the first frame update
    void Start()
    {
        var children = new List<Transform>();
        slider = sliderObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ValueChange()
    {
        foreach (Transform childTransform in ChangeLight.transform)
        {
            childTransform.GetComponent<Light>().intensity = slider.value;
        }
    }
}