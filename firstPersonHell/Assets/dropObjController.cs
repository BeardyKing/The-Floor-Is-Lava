using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropObjController : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject[] objs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float counter = 3f;

    // Update is called once per frame
    void Update(){
        counter -= Time.deltaTime;
        if (counter <= 0) {
            counter = Random.Range(3, 8);
            GameObject temp;
            temp = Instantiate(prefab);
            temp.transform.position = objs[Random.Range(0, objs.Length)].transform.position;
        }        
    }
}
