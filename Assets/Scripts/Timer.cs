using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour //��¥, �ð� �ڵ��̰� �� �̹����� ���� �ȵ�����
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

        //�� ǥ��
        if(LimitTime > 59){
           LimitTime = 0;
           Minute+=1;
        }
        //�ð� ǥ��
        if(Minute > 59)
        {
            Minute = 0;
            Hour++;
        }
        //��¥ ǥ��
        if(Hour > 23)
        {
            Hour = 0;
            date++;
        }

        //Timer UI
        text_Timer.text = " " + Hour + " : " + " " + Minute;
        text_date.text = " " + date + "��°";
    }
}
