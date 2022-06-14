using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CounterManager : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        SceneManager.LoadScene(4);
    }

    public void goShop()
    {
        SceneManager.LoadScene(0);
    }
    
    public void goMake()
    {
        SceneManager.LoadScene(3);
    }//손놈 스포너 만들어야함
}
