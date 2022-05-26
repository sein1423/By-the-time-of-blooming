using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Illustrated : MonoBehaviour
{



    GameManager gm;
    public string[] strArray = new string[13];
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
        flower[0].flowerObject = GameObject.Find("±Û¶óµð¿Ã·¯½º");
        flower[1].flowerObject = GameObject.Find("µ¥ÀÌÁö");
        flower[2].flowerObject = GameObject.Find("µ¨ÇÇ´½");
        flower[3].flowerObject = GameObject.Find("¹ÙÀÌ¿Ã·¿");
        flower[4].flowerObject = GameObject.Find("¼ö¼±È­");
        flower[5].flowerObject = GameObject.Find("¸Þ¸®°ñµå");
        flower[6].flowerObject = GameObject.Find("¾¦ºÎÀïÀÌ");
        flower[7].flowerObject = GameObject.Find("¾ç±Íºñ");
        flower[8].flowerObject = GameObject.Find("Àº¹æ¿ï²É");
        flower[9].flowerObject = GameObject.Find("ÀÚÈ«»ö ±¹È­");
        flower[10].flowerObject = GameObject.Find("Àå¹Ì");
        flower[11].flowerObject = GameObject.Find("Ä«³×ÀÌ¼Ç");
        flower[12].flowerObject = GameObject.Find("ÇÁ¸®Áö¾Æ");

        for (int count = 0; count < 13; count++)
        {
            flower[count].get = gm.boolArray[count];
        }
    }

    // Update is called once per frame
    void Update()
    {

        for (int count = 0; count < 13; count++)
        {
            if (flower[count].get)
            {
                flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                flower[count].flowerObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "È¹µæ";//strArray[count];
            }
            else
            {
                flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(20, 20, 20, 150);
                flower[count].flowerObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "????";
            }
        }

    }

    public void PushExit()
    {
        SceneManager.LoadScene(1);
    }

}
