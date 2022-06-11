using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmDirector : MonoBehaviour //�ð��� ���� �� �̹����� �ʸ���Ʈ �Ǹ鼭 �Ʒ� �ִ� ���� ��(��)�� �������� �ڵ��ε� �ð��̶� �̹����� ���� �ȵ�����
{
    public GameObject[] farms = new GameObject[9];
    public Sprite inFarm, notinFarm,spray;
    //public GameObject[] flowerButton = new GameObject[13];
    public Text selectflowertext;
    public Text WaterCountText;
    public int WaterCount = 6;
    public bool select = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WaterCountText.text = WaterCount.ToString();
    }

    public void ChangeFarm(GameObject go)
    {
        if(selectflowertext.text != "")
        {
            go.GetComponent<Farm>().FarmButton(selectflowertext.text);
        }

    }

    public void selectFlower(GameObject go)
    {
        
        selectflowertext.text = go.transform.GetChild(0).GetComponent<Text>().text;
    }

    public void chargeWater()
    {
        WaterCount = 6;
    }
}
