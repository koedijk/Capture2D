using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

     public float timeLeft = 10f;
     
     public Text text;

    void Start()
    {
        StartCoroutine(Time());
    }
     
     void Update()
     {
         text.text = "" + timeLeft;
         if(timeLeft < 0)
         {
             Debug.Log("times over");
         }
     }

    IEnumerator Time()
    {
        timeLeft--;
        yield return new WaitForSeconds(1);
        StartCoroutine(Time());
    }
 }
