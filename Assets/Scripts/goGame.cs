using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class goGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goIllust()
    {
        SceneManager.LoadScene(4);
    }

    public void goShop()
    {
        SceneManager.LoadScene(0);
    }
}