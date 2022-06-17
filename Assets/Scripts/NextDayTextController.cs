using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextDayTextController : MonoBehaviour
{
    GameManager gm;
    public Text daytext;
    float timecount = 0;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        daytext.text = "Day : " + gm.dayCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timecount += Time.deltaTime;

        if(timecount > 3.0f)
        {
            SceneManager.LoadScene("counter");
        }
    }
}
