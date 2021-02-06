using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class example : MonoBehaviour {

    public GameObject ColorPickedPrefab;
    private ColorPickerTriangle CP;
    //private bool isPaint = false;
    //private GameObject go;
    //private Material mat;

    [SerializeField] GameObject LightGroup;

    void Start()
    {
        //mat = GetComponent<Light>();

        //go = (GameObject)Instantiate(ColorPickedPrefab, transform.position + Vector3.up * 1.4f, Quaternion.identity);
        //go.transform.localScale = Vector3.one * 1.3f;
        //go.transform.LookAt(Camera.main.transform);
        CP = GetComponent<ColorPickerTriangle>();

        foreach (Transform childTransform in LightGroup.transform)
        {
            CP.SetNewColor(childTransform.GetComponent<Light>().color);
        }

        //isPaint = true;
    }

    void Update()
    {
        //if (isPaint)
        //{

        CP = GetComponent<ColorPickerTriangle>();

        foreach (Transform childTransform in LightGroup.transform)
        {
                childTransform.GetComponent<Light>().color = CP.TheColor;
        }
        //}
    }
}
