using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff: MonoBehaviour 
{
    [SerializeField] private GameObject ChangeLight;
    private bool LightOn;


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
        if (LightOn == false)
        {
            foreach (Transform childTransform in ChangeLight.transform)
            {
                childTransform.gameObject.SetActive(true);
                LightOn = true;
            }
        }
        else
        {
            foreach (Transform childTransform in ChangeLight.transform)
            {
                childTransform.gameObject.SetActive(false);
                LightOn = false;
            }
        }
    }
}