using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public string output;
    public string gameObject_name;
    public int i;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        gameObject_name = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject_name + ":" + i.ToString());
    }
}
