using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody playerd;
    public float force = 10000f;
    public float speed =10f;
    public float Xmin = 4.45f ;
    public float Xmax = 4.45f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //setting the player within ground
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, Xmin, Xmax);
        transform.position = playerPos;


        //movement of player with arrow keys
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D) )
        {
            transform.position =transform.position + new Vector3(speed * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey(KeyCode.A))
        {
            transform.position =transform.position - new Vector3(speed * Time.deltaTime,0,0);
        }




    }

    private void FixedUpdate(){
          playerd.AddForce(0,0,force*Time.deltaTime);
    }
}
