using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class score : MonoBehaviour
{
   // private int Score = 100;
   // [SerializeField]private GameObject player;
   [SerializeField] private Text scoreText;
    

    public void updateHealth(int amount)
    {
        if(amount <= 0)
        {
           scoreText.text = 0.ToString();
        }

        if (amount >= 100)
        {
            scoreText.text = 100.ToString();
        }
        else
        {
           scoreText.text = amount.ToString();
        }
      

    }
}

// https://www.youtube.com/watch?v=FQNZwcd6FaY 
