using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject EcsModal;
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
        EcsModal.SetActive(false);
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
                EcsAction();
                break;
            default:
                break;
        }

    }

    public void NormalAction(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            EcsPreAction();
        }
    }
    private void EcsPreAction(){
        GameMode = "Ecs";
        EcsModal.SetActive(true);
        UI.SetActive(false);
        Cursor.visible = true;    // カーソル表示
        fpc.enabled = false;
    }

    public void EcsAction()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            GameMode = "Normal";
            EcsModal.SetActive(false);
            UI.SetActive(true);
            Cursor.visible = false;     // カーソル非表示
            fpc.enabled = true;
        }
    }
}
