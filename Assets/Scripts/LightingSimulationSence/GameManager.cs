using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject EcsUI;
    public GameObject LightUI;
    public GameObject ShowPrefab;
    public bool ShowState;
    public GameObject UI;
    public string GameMode;
    FirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
        ShowState = true;
        GameMode = "Normal";
        EcsUI.SetActive(false);
        LightUI.SetActive(false);
        fpc = player.GetComponent<FirstPersonController>();
        Instantiate(ShowPrefab, ShowPrefab.transform.position, ShowPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        switch (GameMode){
            case "Normal":
                NormalAction();
                break;
            case "Ecs":
                EcsUIAction();
                break;
            case "Light":
                LightUIAction();
                break;
            default:
                GameMode = "Normal";
                break;
        }

    }

    public void NormalAction(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            EcsUIPreAction();
        }
    }
    public void LightUIPreAction(){
        fpc.enabled = false;
        LightUI.SetActive(true);
        EcsUI.SetActive(false);
        Cursor.visible = true;    // カーソル表示
        GameMode = "Light";

    }
    public void LightUIAction()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            GameMode = "Normal";
            LightUI.SetActive(false);
            UI.SetActive(true);
            Cursor.visible = false;     // カーソル非表
            fpc.enabled = true;
        }
    }

    private void EcsUIPreAction(){
        GameMode = "Ecs";
        EcsUI.SetActive(true);
        UI.SetActive(false);
        Cursor.visible = true;    // カーソル表示
        fpc.enabled = false;
    }

    public void EcsUIAction()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            GameMode = "Normal";
            EcsUI.SetActive(false);
            UI.SetActive(true);
            Cursor.visible = false;     // カーソル非表示
            fpc.enabled = true;
        }
    }

    public void SetGameMode(string Mode){
        GameMode = Mode;
        Debug.Log(GameMode);
    }
}
