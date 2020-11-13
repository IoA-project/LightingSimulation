using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private Light PointLight;

    // Start is called before the first frame update
    void Start()
    {
        PointLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        PointLight.enabled = !PointLight.enabled;
    }
}
