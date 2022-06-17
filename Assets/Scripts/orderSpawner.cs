using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orderSpawner : MonoBehaviour
{
    public Text ordertext;
    float Timefloat = 0;
    public GameObject orderObject;
    public GameManager gm;
    
    public struct order
    {
        public string state;
        public string lang;
        public string color;
        public string season;
    }


    public order[] orders = new order[4];
    // Start is called before the first frame update




    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        orderObject.SetActive(!gm.ordercom);
        orders[0].state = "�Ķ� ������ ��� �ּ���";
        orders[0].lang = null;
        orders[0].color = "blue";
        orders[0].season = null;

        orders[1].state = "������ �Ǵ� ������ �ּ���";
        orders[1].lang = null;
        orders[1].color = null;
        orders[1].season = "summer";

        orders[2].state = "�ɸ��� ����� ������ �ּ���";
        orders[2].lang = "���";
        orders[2].color = null;
        orders[2].season = null;

        orders[3].state = "�����̾� 5���� �ּ���"; 
        orders[3].lang = "����";
        orders[3].color = "yellow";
        orders[3].season = "spring";


    }

    // Update is called once per frame
    void Update()
    {
        Timefloat += Time.deltaTime;
        
        if(Timefloat > 3.0 && !orderObject.activeSelf)
        {
            gm.ordercom = false;
            gm.randomOrder = Random.Range(0, orders.Length);
        }
        //�ֹ�â����
        if (!gm.ordercom)
        {
            newOrder();
        }
    }

    public void newOrder()
    {
        orderObject.SetActive(!gm.ordercom);
        ordertext.text = orders[gm.randomOrder].state;
    }

    public void orderComplite()
    {
        int score = 0;
        if(orders[gm.randomOrder].lang != null)
        {
            if(orders[gm.randomOrder].lang == gm.bou1.lang)
            {
                score += 10;
            }
        }

        if(orders[gm.randomOrder].color != null)
        {
            if (orders[gm.randomOrder].color == gm.bou1.color)
            {
                score += 10;
            }
        }

        if(orders[gm.randomOrder].season != null)
        {
            if (orders[gm.randomOrder].season == gm.bou1.season)
            {
                score += 10;
            }
        }

        gm.ordercom = !gm.ordercom;
        orderObject.SetActive(!gm.ordercom);
        Timefloat = 0;
        gm.money += score;
        
    }
}
