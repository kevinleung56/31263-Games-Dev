using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public string output;
    public string gameObject_name;
    public int i;
    public int random;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        random = Random.Range(200, 250);
        gameObject_name = this.gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Red" && i == 100)
        {
            this.gameObject.SetActive(false);
        }
        else if (this.gameObject.tag == "Blue" && i == random)
        {
            rend.enabled = false;
        }

        i++;
        Debug.Log(gameObject_name + ":" + i.ToString());
    }
}
