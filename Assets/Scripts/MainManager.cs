using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
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
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
}
