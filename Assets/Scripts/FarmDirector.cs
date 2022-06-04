using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmDirector : MonoBehaviour //시간에 따라 해 이미지가 필마운트 되면서 아래 있는 검은 해(달)이 보여지는 코드인데 시간이랑 이미지랑 연결 안되있음
{
    GameObject moon;

    // Start is called before the first frame update
    void Start()
    {
        this.moon =GameObject.Find("moon"); //
    }
    public void Moon()
    {
        this.moon.GetComponent<Image>().fillAmount -= 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject director = GameObject.Find("moon");
       // sun.GetComponent<moon>().Moon();
    }
}
