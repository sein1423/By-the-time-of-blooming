using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmDirector : MonoBehaviour //�ð��� ���� �� �̹����� �ʸ���Ʈ �Ǹ鼭 �Ʒ� �ִ� ���� ��(��)�� �������� �ڵ��ε� �ð��̶� �̹����� ���� �ȵ�����
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
