using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public struct Flower
    {
        public GameObject flowerObject;
        public bool get;

    }

    public Flower[] flower = new Flower[13];
    // Start is called before the first frame update
    void Start()
    {
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

        for(int count = 0; count < 13; count++)
        {
            flower[count].get = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetFlower(int number)
    {
        flower[number].get = true;
    }
}
