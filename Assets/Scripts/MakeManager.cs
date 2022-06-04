using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeManager : MonoBehaviour
{
    public Button btnCa, btnDa, btnDe, btnEu, btnFr, btnGl, btnJa, btnMa, btnRo, btnSs, btnSu, btnVi, btnYa, btnArrow;
    public GameObject carnation_pre, daisy_pre, del_pre, eun_pre, freesia_pre, glra_pre, jahng_pre, marry_pre, rose_pre, ssug_pre, susun_pre, violet_pre, yang_pre;
    int count = 0;      //꽃 개수
    int px = 0, py = 0;     //꽃 위치 변수
    int rx = 0, ry =0;      //꽃 회전 변수
    int layer = 0;      //레이어 위치
    

    // Start is called before the first frame update
    void Start()
    {
        
        btnCa.onClick.AddListener(btnCa_clik);  //카네이션 버튼
        btnDa.onClick.AddListener(btnDa_clik);
        btnDe.onClick.AddListener(btnDe_clik);
        btnEu.onClick.AddListener(btnEu_clik);
        btnFr.onClick.AddListener(btnFr_clik);

        btnGl.onClick.AddListener(btnGl_clik);
        btnJa.onClick.AddListener(btnJa_clik);
        btnMa.onClick.AddListener(btnMa_clik);
        btnRo.onClick.AddListener(btnRo_clik);
        btnSs.onClick.AddListener(btnSs_clik);
        
        btnSu.onClick.AddListener(btnSu_clik);
        btnVi.onClick.AddListener(btnVi_clik);
        btnYa.onClick.AddListener(btnYa_clik);

        btnArrow.onClick.AddListener(btnArrow_clik);    //화살표 클릭
        
        
        
        

    }

    // Update is called once per frame
     void Update()
    {
        
    }

     void btnCa_clik()      //카네이션 버튼 클릭 함수
    {
        Debug.Log("카네이션");
        GameObject carnation = Instantiate(carnation_pre) as GameObject;        //카네이션 오브젝트 생성
        pos(count);     //꽃 위치 정하기
        carnation.transform.position = new Vector3(px,py,0);        //카네이션 위치
        carnation.transform.SetSiblingIndex(layer);
        count++;        //꽃 개수 세기
    }
    void btnDa_clik()
    {
        Debug.Log("데이지");
        GameObject dai = Instantiate(daisy_pre) as GameObject;
        pos(count);
        dai.transform.position = new Vector3(px,py,0);
        dai.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnDe_clik()
    {
        Debug.Log("델피니움");
        GameObject del = Instantiate(del_pre) as GameObject;
        pos(count);
        del.transform.position = new Vector3(px,py,0);
        del.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnEu_clik()
    {
        Debug.Log("은방울꽃");
        GameObject eun = Instantiate(eun_pre) as GameObject;
        pos(count);
        eun.transform.position = new Vector3(px,py,0);
        eun.transform.SetSiblingIndex(layer);
        count++;
        
    }
    void btnFr_clik()
    {
        Debug.Log("프리지아");
        GameObject fre = Instantiate(freesia_pre) as GameObject;
        pos(count);
        fre.transform.position = new Vector3(px,py,0);
        fre.transform.SetSiblingIndex(layer);
        count++;
    }




    void btnGl_clik()
    {
        Debug.Log("글라디올러스");
        GameObject glr = Instantiate(glra_pre) as GameObject;
        pos(count);
        glr.transform.position = new Vector3(px,py,0);
        glr.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnJa_clik()
    {
        Debug.Log("자홍색 국화");
        GameObject jah = Instantiate(jahng_pre) as GameObject;
        pos(count);
        jah.transform.position = new Vector3(px,py,0);
        jah.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnMa_clik()
    {
        Debug.Log("메리골드");
        GameObject mar = Instantiate(marry_pre) as GameObject;
        pos(count);
        mar.transform.position = new Vector3(px,py,0);
        mar.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnRo_clik()
    {
        Debug.Log("장미");
        GameObject ros = Instantiate(rose_pre) as GameObject;
        pos(count);
        ros.transform.position = new Vector3(px,py,0);
        ros.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnSs_clik()
    {
        Debug.Log("쑥부쟁이");
        GameObject Ssu = Instantiate(ssug_pre) as GameObject;
        pos(count);
        Ssu.transform.position = new Vector3(px,py,0);
        Ssu.transform.SetSiblingIndex(layer);
        count++;
    }



    void btnSu_clik()
    {
        Debug.Log("수선화");
        GameObject sus = Instantiate(susun_pre) as GameObject;
        pos(count);
        sus.transform.position = new Vector3(px,py,0);
        sus.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnVi_clik()
    {
        Debug.Log("바이올렛");
        GameObject vio = Instantiate(violet_pre) as GameObject;
        pos(count);
        vio.transform.position = new Vector3(px,py,0);
        vio.transform.SetSiblingIndex(layer);
        count++;
    }
    void btnYa_clik()
    {
        Debug.Log("양귀비");
        GameObject yan = Instantiate(yang_pre) as GameObject;
        pos(count);
        yan.transform.position = new Vector3(px,py,0);
        yan.transform.SetSiblingIndex(layer);
        count++;
    }

    void btnArrow_clik()
    {
        Debug.Log("다음");
        //btnCa.SetActive(false);

    }
    

    void pos(int cnt)       //꽃 위치 정하는 함수
    {
        if(cnt == 0)
        {
            px = 0;
            py = -1;
            layer = 1;
        }
        else if(cnt == 1)
        {
            px = -1;
            py = -1;
            layer = 2;
        }
        else if(cnt == 2)
        {
            px = 1;
            py = -1;
            layer = 3;
        }
        else if(cnt == 3)
        {
            px = -2;
            py = -2;
            layer = 4;
        }
        else if(cnt == 4)
        {
            px = 2;
            py = -2;
            layer = 5;
            
        }
    }
}
