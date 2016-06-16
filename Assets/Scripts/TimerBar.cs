using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerBar: MonoBehaviour {
    public float timeLeft = 61f;
    private float time;
    [SerializeField]
    private GameObject timeBar;
    [SerializeField]
    private GameObject Playet1Win;
    [SerializeField]
    private GameObject Player2Win;

    void Awake()
    {
        StartCoroutine(Time());
    }
     
     void Update()
     {
         time = timeLeft / 60f;
         timeBar.transform.localScale = new Vector2(Mathf.Clamp(time,0,1), timeBar.transform.localScale.y);
         if(timeLeft < 0)
         {
             //Wie er wint
         }
     }

    IEnumerator Time()
    {
        timeLeft--;
        yield return new WaitForSeconds(1f);
        StartCoroutine(Time());
    }
 }
