using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{

    private readonly string Player = "Player";

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.tag);

        if(other.gameObject.tag==Player)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
