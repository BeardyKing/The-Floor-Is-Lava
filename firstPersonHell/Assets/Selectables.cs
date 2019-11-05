using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectables : MonoBehaviour
{

    int layer = 10;

    List<GameObject> selectables = new List<GameObject>();

    public Material[] mats = new Material[2];

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] temp = FindObjectsOfType<GameObject>();
        foreach (var item in temp)
        {
            if (item.layer == 10)
            {
                selectables.Add(item);
            }
        }

        foreach (var item in selectables)
        {
            item.AddComponent<MaterialChanger>();
            item.GetComponent<MaterialChanger>().mats = new Material[] { item.GetComponent<Renderer>().material, mats[0], mats[1] };
        }

        Destroy(gameObject);


    }

}
