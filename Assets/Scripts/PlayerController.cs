using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float jump = 5f;
    private bool isGrounded;
   
    private Rigidbody rb;
    private Vector3 JumpInput;
    public int score = 100;
    public score health;
    public GameOverMenu gameOverMenu;
    private int newScore = 0;
    private int damage = 15;
    private int heal = 10;
    

    // Start is called before the first frame update
    void Start()
     {
        rb = GetComponent<Rigidbody>();
        newScore = score;
        gameOverMenu.score = newScore;
        JumpInput = new Vector3(0f, 0.001f, 0f);
    }

     void Damage(int damage)
    {
        newScore -= damage;
        gameOverMenu.score = newScore;
        health.updateHealth(newScore);
      //  gameOverMenu.Number(newScore);
    }

    void Heal(int heal)
    {
        newScore += heal;
        gameOverMenu.score = newScore;
        health.updateHealth(newScore);
    }



    // Update is called once per framelll
     void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;

        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("destroy"))
        {
            Damage(damage);
        }

        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            Heal(heal);
            Debug.Log("Item Picked Up");
        }
    }

    void Update()
    {
       
      //  Vector3  JumpInput = new Vector3(0f, 0f, 0f);
        Vector3 SpeedInput = new Vector3(0f,0f, 0f);
        

        if (Input.GetKey(KeyCode.A))
        {
            SpeedInput.x = -1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            SpeedInput.x = +1;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(JumpInput * jump, ForceMode.Impulse);
            isGrounded= false;
           
        }
        

        SpeedInput = SpeedInput.normalized;
        JumpInput = JumpInput.normalized;
        transform.position += SpeedInput * Speed * Time.deltaTime;
        transform.position +=  jump * JumpInput * Time.deltaTime;
       // Debug.Log(Time.deltaTime);
    }

    // https://forum.unity.com/threads/making-a-gameobject-jump.413728/
    // https://www.youtube.com/watch?v=ctpExP8GaiQ
}
