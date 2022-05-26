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
        for (int count = 0; count < 13; count++)
        {
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

    // Update is called once per frame
    void Update()
    {

        
    }

    public void PushExit()
    {
        SceneManager.LoadScene(1);
    }

}
