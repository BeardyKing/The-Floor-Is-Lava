using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIRenderer : MonoBehaviour
{

    GunController controller;
    LineRenderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GunController>();
        rend = GetComponent<LineRenderer>();
        rend.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {

        if (!controller.shotObjects[1] && !controller.shotObjects[0])
        {
            rend.SetPosition(0, Vector3.one * 100);
            rend.SetPosition(1, Vector3.one * 100);
        }else
        if (controller.shotObjects[0] != null) {

            rend.SetPosition(0, controller.shotObjects[0].transform.position);


            if (controller.nextTarget() != null)
            {
                rend.SetPosition(1, controller.nextTarget().position);
            }
            else
            {
                rend.SetPosition(1, controller.shotObjects[0].transform.position);
            }
          

        }else
              if (controller.shotObjects[1] != null)
        {

            rend.SetPosition(0, controller.shotObjects[1].transform.position);


            if (controller.nextTarget() != null)
            {
                rend.SetPosition(1, controller.nextTarget().position);
            }
            else
            {
                rend.SetPosition(1, controller.shotObjects[0].transform.position);
            }


        }


    }
}
