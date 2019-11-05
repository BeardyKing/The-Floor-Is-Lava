using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSmallerOverTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (getSmaller) {
            transform.localScale = new Vector3(1.5f, transform.localScale.y - (Time.deltaTime / 7), 1.5f);
        }
        if (transform.localScale.y < .05f) {
            Destroy(gameObject);
        }
    }
    bool getSmaller;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.layer == 11) {
            getSmaller = true;
        }
    }
}
