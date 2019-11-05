using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnMove : MonoBehaviour
{
    public GameObject toDestroy;
    public GameObject walls;
    public GameObject ceiling;
    public GameObject floor;

    float timer;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, startPos) > .4f)
        {
            Destroy(toDestroy);

            timer += Time.deltaTime;

        }

        if(timer > 1.5f)
        {
            wallFall();
        }

        
    }


    void wallFall()
    {
        walls.transform.position = walls.transform.position + Vector3.down * Time.deltaTime * 20f;

        if (ceiling)
        {
            Destroy(ceiling);
            Destroy(floor);
        }
    }
}
