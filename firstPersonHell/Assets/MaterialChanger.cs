using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{

    public Material[] mats;

    public GunController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GunController>();
    }

    // Update is called once per frame
    void Update()
    {


        if(controller.shotObjects[0] == this.gameObject || controller.shotObjects[0] == transform.parent.gameObject)
        {
            GetComponent<Renderer>().material = mats[1];

    

        }
        else
        {

            GetComponent<Renderer>().material = mats[0];
        }

    }
}
