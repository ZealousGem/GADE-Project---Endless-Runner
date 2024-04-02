using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private float timmy = 0.0f;
    public int timer;
    public Text no;
    public Text yes;
    [SerializeField] private GameOverMenu gameOverMenu;

    // Update is called once per frame
     void Update()
    {
        if (gameOverMenu.isActive is false)
        {
            
            timmy +=  Time.deltaTime;
            timer = (int)(timmy);
            no.text = timer.ToString();
           // Debug.Log(timer.ToString());

        }

        else
        {
            no.text = timer.ToString();
            no.enabled = false;
            yes.enabled = false;
        }
           
        
    }

    // https://discussions.unity.com/t/how-to-make-a-timer-that-counts-up-in-seconds-as-an-int/147546/5 
}
