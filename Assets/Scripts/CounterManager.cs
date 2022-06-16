using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CounterManager : MonoBehaviour
{
    GameManager gm;
    public Text dayText;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        dayText.text = "Day : " + gm.dayCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void goIllust()
    {/*
        for (int count = 0; count < 13; count++)
        {
            Debug.Log(gm.flower[count].count.ToString());
        }*/
        SceneManager.LoadScene("illustrated");
    }

    public void goShop()
    {
        SceneManager.LoadScene("shop");
    }
    
    public void goMake()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("make");
    }

    public void goFarm()
    {
        SceneManager.LoadScene("FarmScene");
    }

    public void goNextDay()
    {
        gm.NextDay();
    }
=======
        SceneManager.LoadScene(3);
    }//손놈 스포너 만들어야함
>>>>>>> 74e524069d4f99d78b17226c92554c9f4c6f2892
}
