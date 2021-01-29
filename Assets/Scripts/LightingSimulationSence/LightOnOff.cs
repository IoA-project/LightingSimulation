using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff: MonoBehaviour
{
    public GameObject LightGroup;

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
        if (LightGroup.activeSelf)
        {
            LightGroup.SetActive(false);
        }
        else
        {
            LightGroup.SetActive(true);
        }
    }
}