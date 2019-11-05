using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{

    private readonly string Player = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.tag);

        if(collision.gameObject.tag==Player)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
