using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    public GameObject particle;
    public int a = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Onclick()
    {
        if (a == 0)
        {
            Instantiate(particle, transform.position, transform.rotation);
            a++;
        }
        else if(a == 1)
        {
            GameObject obj = GameObject.Find("Snow(Clone)");
            Destroy(obj);
            a--;
        }
    }
    void Update()
    {
        
    }
}
