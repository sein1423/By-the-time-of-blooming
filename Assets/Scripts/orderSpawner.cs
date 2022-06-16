using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orderSpawner : MonoBehaviour
{
    public Text ordertext;
    float Timefloat = 0;
    public GameObject orderObject;
    // Start is called before the first frame update
    void Start()
    {
        orderObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Timefloat += Time.deltaTime;
        
        if(Timefloat > 3.0)
        {
            orderObject.SetActive(true);
            ordertext.text = "주문이용";
        }
    }
}
