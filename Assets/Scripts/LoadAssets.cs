using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;

    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
        var redPosition = new Vector3(2, 0, 0);
        var redRotation = new Quaternion(0, 0, 0, 0);
        var bluePosition = new Vector3(-2, 0, 0);
        var blueRotation = new Quaternion(0, 0, 0, 0);
        var redObject = Instantiate(redObj, redPosition, redRotation);
        var blueObject = Instantiate(blueObj, bluePosition, blueRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
