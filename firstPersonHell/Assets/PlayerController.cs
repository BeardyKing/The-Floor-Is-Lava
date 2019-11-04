using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    [SerializeField] private bool hideMouse;
    private Camera cam;
    private Rigidbody rb;
    [SerializeField] private float speed = 1;
    [SerializeField] private Vector3 direction;
    [SerializeField] private Vector3 rotationEuler;
    
    
    private void Start(){
        Cursor.visible = hideMouse;
        Cursor.lockState = CursorLockMode.Locked;
        
        cam = FindObjectOfType<Camera>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update(){
        RotatePlayer();
        PlayerMovement();
    }

    private float maxHeight,minHeight;
    private void RotatePlayer(){
        rotationEuler += new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"),0);
        
        if (rotationEuler.x > 60){
            rotationEuler = new Vector3(60,rotationEuler.y,0);
        }
        if (rotationEuler.x < -60){
            rotationEuler = new Vector3(-60,rotationEuler.y,0);
        }

        transform.eulerAngles = new Vector3(0,rotationEuler.y,0);
        cam.transform.localEulerAngles = new Vector3(rotationEuler.x,0 , 0);
    }
    Vector3 inDir;

    private float timer;
    private void PlayerMovement(){
        if (Input.GetButtonDown("Jump")){
            rb.AddForce(Vector3.up * 200);
            timer = .2f;
        }
        inDir = Vector3.zero;
            direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            if (direction.z != 0){
                rb.AddForce(transform.forward * direction.z * 4);
            }
            if (direction.x != 0){
                rb.AddForce(transform.right * direction.x * 4);
            }

            if (direction.x == 0 && direction.z == 0){
                    rb.velocity = new Vector3(rb.velocity.x / 128, rb.velocity.y, rb.velocity.z / 128);
            }


    }
}
