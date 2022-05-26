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
        flower[0].flowerObject = GameObject.Find("글라디올러스");
        flower[1].flowerObject = GameObject.Find("데이지");
        flower[2].flowerObject = GameObject.Find("델피늄");
        flower[3].flowerObject = GameObject.Find("바이올렛");
        flower[4].flowerObject = GameObject.Find("수선화");
        flower[5].flowerObject = GameObject.Find("메리골드");
        flower[6].flowerObject = GameObject.Find("쑥부쟁이");
        flower[7].flowerObject = GameObject.Find("양귀비");
        flower[8].flowerObject = GameObject.Find("은방울꽃");
        flower[9].flowerObject = GameObject.Find("자홍색 국화");
        flower[10].flowerObject = GameObject.Find("장미");
        flower[11].flowerObject = GameObject.Find("카네이션");
        flower[12].flowerObject = GameObject.Find("프리지아");


        for (int count = 0; count < 13; count++)
        {
            flower[count].get = gm.boolArray[count];

            if (gm.boolArray[count])
            {
                flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                flower[count].flowerObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "완료";
            }
            else
            {
                flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(20, 20, 20, 150);
                flower[count].flowerObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "구입";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void GetItem(GameObject go)
    {
        go.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255,255,255,255);
        go.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "완료";
        for(int count = 0; count < 13; count++)
        {
            if(flower[count].flowerObject.name == go.name)
            {
                gm.boolArray[count] = true;
                break;
            }
        }
    }
    public void PushExit()
    {
        SceneManager.LoadScene(1);
    }
}
