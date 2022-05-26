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

        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void GetItem(GameObject go)
    {
        go.transform.GetChild(0).gameObject.GetComponent<Image>().color = new Color32(255,255,255,255);
        go.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "¿Ï·á";
    }
    public void PushExit()
    {
        SceneManager.LoadScene(1);
    }
}
