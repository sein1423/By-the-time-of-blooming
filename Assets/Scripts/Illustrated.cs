using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Illustrated : MonoBehaviour
{
    GameManager gm;
    public string[] strArray = new string[13];
    public bool[] boolArray = new bool[13];
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        for (int count = 0; count < 13; count++)
        {
            gm.flower[count].get = boolArray[count];

            if (gm.flower[count].get)
            {
                gm.flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                gm.flower[count].flowerObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "È¹µæ";//strArray[count];
            }
            else
            {
                gm.flower[count].flowerObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(20, 20, 20, 150);
                gm.flower[count].flowerObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = "????";
            }
        }
    }
}
