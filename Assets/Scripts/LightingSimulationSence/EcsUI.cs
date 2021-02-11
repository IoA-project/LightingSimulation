using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EcsUI : MonoBehaviour
{
    public GameObject GameManager;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetComponent<GameManager>();

    }

    // Update is called once per frame
    public void WeatherChangeOnClick()
    {
        if (gm.ShowState)
        {
            GameObject obj = GameObject.Find("Snow(Clone)");
            Destroy(obj);
        }
        else
        {
            Instantiate(gm.ShowPrefab, gm.ShowPrefab.transform.position, gm.ShowPrefab.transform.rotation);
        }
        gm.ShowState = !gm.ShowState;
    }
    public void LightingOnClick()
    {
        gm.LightUIPreAction();
        gm.SetGameMode("Light");
    }

    public void EndBottonOnClick(){
      UnityEditor.EditorApplication.isPlaying = false;
      UnityEngine.Application.Quit();
    }

    void Update()
    {

    }
}
