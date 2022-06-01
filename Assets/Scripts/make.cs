using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class make : MonoBehaviour
{
    public GameObject carnation_pre; 
    public GameObject daisy_pre; 
    Button carnation_btn;
    Button daisy_btn;

    
    void Start()
    {
        carnation_btn = GameObject.Find("canation_btn").GetComponent<Button>();
        carnation_btn.onClick.AddListener(carnation);
        daisy_btn = GetComponent<Button>();
        daisy_btn.onClick.AddListener(daisy);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void carnation()
    {
        Debug.Log("카네이션");
        GameObject car = Instantiate(carnation_pre) as GameObject;
        car.transform.position = new Vector3(0,0,0);
    }
    public void daisy()
    {
        Debug.Log("데이지");
        GameObject dai = Instantiate(daisy_pre) as GameObject;
        dai.transform.position = new Vector3(-0,-1,0);
    }
}
