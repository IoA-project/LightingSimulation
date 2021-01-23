using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LightOnOff: MonoBehaviour
{
    public GameObject LightGroup1;

    // Start is called before the first frame update
    void Start()
    {
        var children = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        if (LightGroup1.activeSelf)
        {
            LightGroup1.SetActive(false);
        }
        else
        {
            LightGroup1.SetActive(true);
        }
    }
}