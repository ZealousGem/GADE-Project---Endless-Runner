using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10;
    //private Rigidbody rb;
   [SerializeField] private Vector3 endPos = new Vector3 (0.06f, 3.07f, -8.64f);
    void Start()
    {
       // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != endPos)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
        }

      
    }

    


}

// https://forum.unity.com/threads/making-an-object-move-and-then-stop-when-it-reaches-a-certain-point.440465/ 
