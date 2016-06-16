using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
     public float timeLeft = 10f;
     private float time;
     [SerializeField]
     private GameObject timeBar;

    void Start()
    {
        StartCoroutine(Time());
    }
     
     void FixedUpdate()
     {
         time = timeLeft / 10;
         timeBar.transform.localScale = new Vector2(Mathf.Clamp(time,0,1), timeBar.transform.localScale.y);
         if(timeLeft < 0)
         {
             Debug.Log("times over");
         }
     }

    IEnumerator Time()
    {
        timeLeft--;
        yield return new WaitForSeconds(1f);
        StartCoroutine(Time());
    }
 }
