using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureOffset : MonoBehaviour
{
    Material mat;
    // Start is called before the first frame update
    void Start(){
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update(){
        mat.SetTextureOffset(1, new Vector2(Time.time / 32, Time.time / 32));
    }
}
