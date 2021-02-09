using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPalette : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    [SerializeField] GameObject LightGroup;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform childTransform in LightGroup.transform)
        {
            childTransform.GetComponent<Light>().color = fcp.color;
        }
    }
}
