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


    public order[] orders = new order[3];
    // Start is called before the first frame update



    void Start()
    {
        orderObject.SetActive(false);
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
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

    }

    // Update is called once per frame
    void Update()
    {
        Timefloat += Time.deltaTime;
        
        if(Timefloat > 3.0 && !orderObject.activeSelf)
        {
            newOrder();
        }
    }

    public void newOrder()
    {

        int randomOrder = Random.Range(0, orders.Length);
        orderObject.SetActive(true);
        ordertext.text = orders[randomOrder].state;
    }

    public void orderComplite()
    {
        orderObject.SetActive(false);
        Timefloat = 0;
        gm.money += 10;
    }
}
