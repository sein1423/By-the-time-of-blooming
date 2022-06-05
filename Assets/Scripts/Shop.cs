using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour
{
    GameManager gm;
    public struct Flower
    {
        public GameObject flowerObject;
        public bool get;

    }

    public Flower[] flower = new Flower[13];
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        flower[0].flowerObject = GameObject.Find("�۶��÷���");
        flower[1].flowerObject = GameObject.Find("������");
        flower[2].flowerObject = GameObject.Find("���Ǵ�");
        flower[3].flowerObject = GameObject.Find("���̿÷�");
        flower[4].flowerObject = GameObject.Find("����ȭ");
        flower[5].flowerObject = GameObject.Find("�޸����");
        flower[6].flowerObject = GameObject.Find("��������");
        flower[7].flowerObject = GameObject.Find("��ͺ�");
        flower[8].flowerObject = GameObject.Find("������");
        flower[9].flowerObject = GameObject.Find("��ȫ�� ��ȭ");
        flower[10].flowerObject = GameObject.Find("���");
        flower[11].flowerObject = GameObject.Find("ī���̼�");
        flower[12].flowerObject = GameObject.Find("��������");


        rodtls();
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void GetItem(GameObject go)
    {
        go.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255,255,255,255);
        for (int count = 0; count < 13; count++)
        {
            if(flower[count].flowerObject.name == go.name)
            {
                gm.flower[count].get = true;
                gm.flower[count].count++;
                break;
            }
        }
        rodtls();
    }
    public void PushExit()
    {/*
        for(int count = 0; count<13; count++)
        {
            Debug.Log(gm.flower[count].count.ToString());
        }*/
        SceneManager.LoadScene(1);
    }

    public void rodtls()
    {
        for (int count = 0; count < 13; count++)
        {
            flower[count].get = gm.flower[count].get;

            if (gm.flower[count].get)
            {
                flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                flower[count].flowerObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = gm.flower[count].count.ToString();
            }
            else
            {
                flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(20, 20, 20, 150);
                flower[count].flowerObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "����";
            }
        }
    }
}
