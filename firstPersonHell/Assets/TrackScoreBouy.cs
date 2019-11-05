using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackScoreBouy : MonoBehaviour
{
    [SerializeField] Text txt_best;
    [SerializeField] Text txt_current;

    float current;
    int best;


    // Start is called before the first frame update
    void Start()
    {
        if (aaaaa) {
            PlayerPrefs.SetInt("BEST!", 0);
        }
    }

    [SerializeField] bool aaaaa;

    // Update is called once per frame
    void Update()
    {
        best = PlayerPrefs.GetInt("BEST!");
        current += Time.deltaTime;

        txt_current.text = Mathf.FloorToInt(current).ToString();
        
        if (current > best) {
            PlayerPrefs.SetInt("BEST!", Mathf.FloorToInt((int)current));
            txt_best.text = Mathf.FloorToInt(current).ToString();
        }
        else {
            txt_best.text = best.ToString();
        }
    }
}
