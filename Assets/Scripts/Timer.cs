using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour //날짜, 시간 코드이고 해 이미지랑 연결 안되있음
{
    public float LimitTime = 0;
    public Text text_Timer;
    public Text text_date;
    public float Hour;
    public float Minute;
    public float date;
    GameObject moon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitTime += Time.deltaTime;
        //Minute = (int)Mathf.Round(LimitTime)/60;

        //분 표시
        if(LimitTime > 59){
           LimitTime = 0;
           Minute+=1;
        }
        //시간 표시
        if(Minute > 59)
        {
            Minute = 0;
            Hour++;
        }
        //날짜 표시
        if(Hour > 23)
        {
            Hour = 0;
            date++;
        }

        //Timer UI
        text_Timer.text = " " + Hour + " : " + " " + Minute;
        text_date.text = " " + date + "일째";
    }
}
