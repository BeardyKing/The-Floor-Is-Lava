using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GunController : MonoBehaviour{
    [SerializeField] private GameObject hitObj;
    private Camera cam;
    private List<GameObject> hitList = new List<GameObject>();
    private GameObject[] shootPoints = new GameObject[2];
    private GameObject[] shotObjects = new GameObject[2];
    
    void Start(){
        cam = FindObjectOfType<Camera>();
    }

    private bool doOnce;
    void Update(){
        if (Input.GetButtonDown("Fire1")){
            SetObjectInArray(0);
            //doOnce = true;
            //RaycastHit hit;
            //var ray = cam.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2,0));

            //if (Physics.Raycast(ray, out hit)){
            //    if (!shootPoints[0]){
            //        shootPoints[0] = Instantiate(hitObj);
            //    }

            //    shootPoints[0].name = "A";
            //    shootPoints[0].transform.position = hit.point;
            //    shotObjects[0] = hit.transform.gameObject;
            //}
        }

        if (Input.GetButtonDown("Fire2")){
            SetObjectInArray(1);
            //doOnce = true;
            //RaycastHit hit;
            //var ray = cam.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2,0));

            //if (Physics.Raycast(ray, out hit)){

            //    if (Physics.Raycast(ray, out hit)){
            //        if (hit.collider.gameObject.layer == 10) {
            //            if (!shootPoints[1]){
            //                shootPoints[1] = Instantiate(hitObj);
            //            }

            //            shootPoints[1].name = "B";
            //            shootPoints[1].transform.position = hit.point;
            //            shotObjects[1] = hit.transform.gameObject;
            //        }
            //    }
            //}
        }

        if (shotObjects[0] != shotObjects[1]){
            if (doOnce){
                doOnce = false;
                Vector3 dir0,dir1;
                dir0 = (shotObjects[1].transform.position - shotObjects[0].transform.position) ;
                dir1 = (shotObjects[0].transform.position - shotObjects[1].transform.position) ;

                shotObjects[0].GetComponent<Rigidbody>().velocity = dir0.normalized * 20;
                shotObjects[1].GetComponent<Rigidbody>().velocity = dir1.normalized * 20;
                
                shotObjects = new GameObject[2];
                
                Destroy(shootPoints[0]);
                Destroy(shootPoints[1]);
            }
        }
    }

    void SetObjectInArray(int choice){
        doOnce = true;
        RaycastHit hit;
        var ray = cam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(ray, out hit)) {

            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.gameObject.layer == 10) {
                    if (!shootPoints[choice]) {
                        shootPoints[choice] = Instantiate(hitObj);
                    }

                    shootPoints[choice].name = "B";
                    shootPoints[choice].transform.position = hit.point;
                    shotObjects[choice] = hit.transform.gameObject;
                }
            }
        }
    }
}
