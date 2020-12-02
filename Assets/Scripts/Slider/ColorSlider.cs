using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorSlider : MonoBehaviour
{
    [SerializeField] GameObject ChangeLight;
    public GameObject lightObject;
    
    public Slider sliderRed;
    public Slider sliderGreen;
    public Slider sliderBlue;

    // Start is called before the first frame update
    void Start()
    {
        var children = new List<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ValueChange()
    {
        float x = sliderRed.value;
        float y = sliderGreen.value;
        float z = sliderBlue.value;
        foreach (Transform childTransform in ChangeLight.transform)
        {
            childTransform.GetComponent<Light>().color = new Color(x, y, z, 1);
        }
    }
}
