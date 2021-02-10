using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherChange : MonoBehaviour
{
    public GameObject ShowPrefab;
    private bool ShowState = false;
    // Start is called before the first frame update
    void Start()
    {
        ShowState = !ShowState;
        Instantiate(ShowPrefab, ShowPrefab.transform.position, ShowPrefab.transform.rotation);
    }

    // Update is called once per frame
    public void OnClick()
    {
        ShowState = !ShowState;
        if (ShowState)
        {
            Instantiate(ShowPrefab, ShowPrefab.transform.position, ShowPrefab.transform.rotation);
        }
        else
        {
            GameObject obj = GameObject.Find("Snow(Clone)");
            Destroy(obj);
        }
    }
    void Update()
    {

    }
}
