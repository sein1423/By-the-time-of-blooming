using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeManager : MonoBehaviour
{
<<<<<<< HEAD:Assets/Scripts/test2.cs
    public Button btnCa, btnDa, btnDe, btnEu, btnFr, btnGl, btnJa, btnMa, btnRo, btnSs, btnSu, btnVi, btnYa, btnNext, btnCom;   //꽃 선택 버튼
    public Button btnRad, btnGreen, btnOrang, btnBlue, btnPurple;    //꽃다발 색깔 버튼
    public GameObject G_btnCa, G_btnDa, G_btnDe, G_btnEu, G_btnFr, G_btnGl, G_btnJa, G_btnMa, G_btnRo, G_btnSs, G_btnSu, G_btnVi, G_btnYa, G_btnNext, G_btnCom;
    public GameObject G_btnRad, G_btnGreen, G_btnOrang, G_btnBlue, G_btnPurple;
    public GameObject carnation_pre, daisy_pre, del_pre, eun_pre, freesia_pre, glra_pre, jahng_pre, marry_pre, rose_pre, ssug_pre, susun_pre, violet_pre, yang_pre; 
    //꽃 프리팹
    public GameObject radt_pre, orangt_pre, greent_pre, bluet_pre, puplet_pre, radb_pre, orangb_pre, greenb_pre, blueb_pre, pupleb_pre;
    //꽃다발 프리팹
    int max = 4;        //꽃 최대 개수
=======
    public Button btnCa, btnDa, btnDe, btnEu, btnFr, btnGl, btnJa, btnMa, btnRo, btnSs, btnSu, btnVi, btnYa, btnArrow;
    public GameObject carnation_pre, daisy_pre, del_pre, eun_pre, freesia_pre, glra_pre, jahng_pre, marry_pre, rose_pre, ssug_pre, susun_pre, violet_pre, yang_pre;
>>>>>>> 01a067f311535ffac7914a9f54a46eadc32476fb:Assets/Scripts/MakeManager.cs
    int count = 0;      //꽃 개수
    float px = 0, py = 0;     //꽃 위치 변수
    int rx = 0, ry =0;      //꽃 회전 변수
    int layer = 0;      //레이어 위치
    int[] language = new int[9];    //꽃말 속성      배열값 순서 :love, happy, friendship, secret, free, narcissism, longing, consolation, thank
    int[] color = new int[6];       //꽃 색깔 속성  배열값 순서 : rad, yellow, blue, purple, pink, white;
    int[] season = new int[4];      //꽃 계절 속성  배열값 순서: 봄,여름,가을,겨울

    void Start()
    {
        

        
         //꽃 선택 버튼
        btnCa.onClick.AddListener(btnCa_clik); 
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

        btnNext.onClick.AddListener(btnNext_clik);    //다음 화살표 클릭

        //꽃다발 색 버튼
        btnRad.onClick.AddListener(btnRad_clik);
        btnOrang.onClick.AddListener(btnOrang_clik);
        btnGreen.onClick.AddListener(btnGreen_clik);
        btnBlue.onClick.AddListener(btnBlue_clik);
        btnPurple.onClick.AddListener(btnPurple_clik);

        btnCom.onClick.AddListener(btnCom_clik);    //완료 버튼 클릭

       
        
        
        
        

    }

    // Update is called once per frame
     void Update()
    {
        
    }

     void btnCa_clik()      //카네이션 버튼 클릭 함수
    {
        if(count <= max){
            Debug.Log("카네이션");
            GameObject carnation = Instantiate(carnation_pre) as GameObject;        //카네이션 오브젝트 생성
            pos(count);     //꽃 위치 정하기
            carnation.transform.position = new Vector3(px,py,0);        //카네이션 위치
            carnation.transform.SetSiblingIndex(layer);                 //카네이션 레이어 위치 였는데 안댐...
            count++;
            //속성
            language[8]++;
            color[0]++;
            season[1]++;
            Debug.Log("감사:"+ language[8] + ", 빨강:" + color[0] + ", 여름:" + season[1]);
        }
                //꽃 개수 세기
    }
    void btnDa_clik()
    {
        if(count <= max){
            Debug.Log("데이지");
            GameObject dai = Instantiate(daisy_pre) as GameObject;
            pos(count);
            dai.transform.position = new Vector3(px,py,0);
            dai.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[0]++;
            color[5]++;
            season[0]++;
            Debug.Log("사랑:"+ language[0] + ", 하양:" + color[5] + ", 봄:" + season[0]);
        }
        
    }
    void btnDe_clik()
    {
        if(count <= max){
            Debug.Log("델피니움");
            GameObject del = Instantiate(del_pre) as GameObject;
            pos(count);
            del.transform.position = new Vector3(px,py,0);
            del.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[4]++;
            color[2]++;
            season[0]++;
            Debug.Log("자유:"+ language[4] + ", 파랑:" + color[2] + ", 봄:" + season[0]);
        }
        
    }
    void btnEu_clik()
    {
        if(count <= max){
            Debug.Log("은방울꽃");
            GameObject eun = Instantiate(eun_pre) as GameObject;
            pos(count);
            eun.transform.position = new Vector3(px,py,0);
            eun.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[1]++;
            color[5]++;
            season[0]++;
            Debug.Log("행복:"+ language[1] + ", 하양:" + color[5] + ", 봄:" + season[0]);

        }
        
        
    }
    void btnFr_clik()
    {
        if(count <= max){
            Debug.Log("프리지아");
            GameObject fre = Instantiate(freesia_pre) as GameObject;
            pos(count);
            fre.transform.position = new Vector3(px,py,0);
            fre.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[2]++;
            color[1]++;
            season[0]++;
            Debug.Log("우정:"+ language[2] + ", 노랑:" + color[1] + ", 봄:" + season[0]);
        }
        
    }




    void btnGl_clik()
    {
        if(count <= max){
            Debug.Log("글라디올러스");
            GameObject glr = Instantiate(glra_pre) as GameObject;
            pos(count);
            glr.transform.position = new Vector3(px,py,0);
            glr.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[3]++;
            color[0]++;
            season[1]++;
            Debug.Log("비밀:"+ language[3] + ", 빨강:" + color[0] + ", 여름:" + season[1]);
        }
        
    }
    void btnJa_clik()
    {
        if(count <= max){
            Debug.Log("자홍색 국화");
            GameObject jah = Instantiate(jahng_pre) as GameObject;
            pos(count);
            jah.transform.position = new Vector3(px,py,0);
            jah.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[0]++;
            color[4]++;
            season[2]++;
            Debug.Log("사랑:"+ language[0] + ", 분홍:" + color[4] + ", 가을:" + season[2]);
        }
        
    }
    void btnMa_clik()
    {
        if(count <= max){
            Debug.Log("메리골드");
            GameObject mar = Instantiate(marry_pre) as GameObject;
            pos(count);
            mar.transform.position = new Vector3(px,py,0);
            mar.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[1]++;
            color[1]++;
            season[1]++;
            Debug.Log("행복:"+ language[1] + ", 노랑:" + color[1] + ", 여름:" + season[1]);
        }
        
    }
    void btnRo_clik()
    {
        if(count <= max){
            Debug.Log("장미");
            GameObject ros = Instantiate(rose_pre) as GameObject;
            pos(count);
            ros.transform.position = new Vector3(px,py,0);
            ros.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[0]++;
            color[0]++;
            season[1]++;
            Debug.Log("사랑:"+ language[0] + ", 빨강:" + color[0] + ", 여름:" + season[1]);
        }
        
    }
    void btnSs_clik()
    {
        if(count <= max){
            Debug.Log("쑥부쟁이");
            GameObject Ssu = Instantiate(ssug_pre) as GameObject;
            pos(count);
            Ssu.transform.position = new Vector3(px,py,0);
            Ssu.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[6]++;
            color[3]++;
            season[2]++;
            Debug.Log("그리움:"+ language[6] + ", 보라:" + color[3] + ", 가을:" + season[2]);
            
        }
        
    }



    void btnSu_clik()
    {
        if(count <= max){
            Debug.Log("수선화");
            GameObject sus = Instantiate(susun_pre) as GameObject;
            pos(count);
            sus.transform.position = new Vector3(px,py,0);
            sus.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[5]++;
            color[1]++;
            season[3]++;
            Debug.Log("자기애:"+ language[5] + ", 노랑:" + color[1] + ", 겨울:" + season[3]);
        }
        
    }
    void btnVi_clik()
    {
        if(count <= max){
            Debug.Log("바이올렛");
            GameObject vio = Instantiate(violet_pre) as GameObject;
            pos(count);
            vio.transform.position = new Vector3(px,py,0);
            vio.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[2]++;
            color[3]++;
            season[0]++;
            Debug.Log("우정:"+ language[2] + ", 보라:" + color[3] + ", 봄:" + season[0]);
        }
        
    }
    void btnYa_clik()
    {
        if(count <= max){
            Debug.Log("양귀비");
            GameObject yan = Instantiate(yang_pre) as GameObject;
            pos(count);
            yan.transform.position = new Vector3(px,py,0);
            yan.transform.SetSiblingIndex(layer);
            count++;
            //속성
            language[7]++;
            color[0]++;
            season[1]++;
            Debug.Log("위로:"+ language[7] + ", 빨강:" + color[0] + ", 여름:" + season[1]);
        }
        
    }


    //꽃다발 선택
    void btnRad_clik()
    {
        Debug.Log("빨강");
        GameObject Rt = Instantiate(radt_pre) as GameObject;
        GameObject Rb = Instantiate(radb_pre) as GameObject;
    }

    void btnOrang_clik()
    { 
        Debug.Log("주황");
        GameObject Ot = Instantiate(orangb_pre) as GameObject;
        GameObject Ob = Instantiate(orangt_pre) as GameObject;
    }

    void btnGreen_clik()
    {
        Debug.Log("초록");
        GameObject Gt = Instantiate(greenb_pre) as GameObject;
        GameObject Gb = Instantiate(greent_pre) as GameObject;
    }

    void btnBlue_clik()
    {
        Debug.Log("파랑");
        GameObject Bt = Instantiate(blueb_pre) as GameObject;
        GameObject Bb = Instantiate(bluet_pre) as GameObject;
    }

    void btnPurple_clik()
    {
        Debug.Log("보라");
        GameObject Pt = Instantiate(pupleb_pre) as GameObject;
        GameObject Pb = Instantiate(puplet_pre) as GameObject;
    }

    
    void btnNext_clik()     //다음 버튼 클릭
    {
        bool flower_btn = false;
        bool color_btn = true;
        Debug.Log("다음");
<<<<<<< HEAD:Assets/Scripts/test2.cs
        //꽃 버튼 사라짐
        G_btnCa.SetActive(flower_btn);
        G_btnDa.SetActive(flower_btn);
        G_btnDe.SetActive(flower_btn);
        G_btnFr.SetActive(flower_btn);
        G_btnGl.SetActive(flower_btn);

        G_btnJa.SetActive(flower_btn);
        G_btnMa.SetActive(flower_btn);
        G_btnRo.SetActive(flower_btn);
        G_btnSs.SetActive(flower_btn);
        G_btnSu.SetActive(flower_btn);

        G_btnVi.SetActive(flower_btn);
        G_btnYa.SetActive(flower_btn);
        G_btnEu.SetActive(flower_btn);

        G_btnNext.SetActive(flower_btn);

        //꽃다발 버튼 나타남
        G_btnRad.SetActive(color_btn);
        G_btnOrang.SetActive(color_btn);
        G_btnGreen.SetActive(color_btn);
        G_btnBlue.SetActive(color_btn);
        G_btnPurple.SetActive(color_btn);

        G_btnCom.SetActive(color_btn);
=======
        //btnCa.SetActive(false);
>>>>>>> 01a067f311535ffac7914a9f54a46eadc32476fb:Assets/Scripts/MakeManager.cs

    }


    //완료 버튼 누르면.....
    void btnCom_clik()
    {
        score("color");
    }

    void clean()  // 그냥 꽃다발을 초기화 하고 싶었을뿐인데 실패함
    {
        bool cleans = false;
        radt_pre.SetActive(cleans);
        radb_pre.SetActive(cleans);
        orangb_pre.SetActive(cleans);
        orangt_pre.SetActive(cleans);
        greenb_pre.SetActive(cleans);
        greent_pre.SetActive(cleans);
        blueb_pre.SetActive(cleans);
        bluet_pre.SetActive(cleans);
        pupleb_pre.SetActive(cleans);
        puplet_pre.SetActive(cleans);

    }

        

    void pos(float cnt)       //꽃 위치 정하는 함수
    {
        if(cnt == 0)
        {
            px = 0;
            py = -1;
            layer = 1;
        }
        else if(cnt == 1)
        {
            px = -1.5f;
            py = -1;
            layer = 2;
        }
        else if(cnt == 2)
        {
            px = 1.5f;
            py = -1;
            layer = 3;
        }
        else if(cnt == 3)
        {
            px = -0.5f;
            py = -2;
            layer = 4;
        }
        else if(cnt == 4)
        {
            px = 0.5f;
            py = -2;
            layer = 5;
            
        }
        
    }


    //속성 점수 계산함수
    void score(string type)
    {
        if(type == "language")
        {
            for(int i = 0; i < 9; i++)
            {
                max = 0;
                if(language[i] > max)
                {
                    max = i;
                }
            }

            if(max == 0)
            {
                Debug.Log("사랑 속성");
            }
            else if(max == 1)
            {
                Debug.Log("행복 속성");
            }
            else if(max == 2)
            {
                Debug.Log("우정 속성");
            }
            else if(max == 3)
            {
                Debug.Log("비밀 속성");
            }
            else if(max == 4)
            {
                Debug.Log("자유 속성");
            }
            else if(max == 5)
            {
                Debug.Log("자기애 속성");
            }
            else if(max == 6)
            {
                Debug.Log("그리움 속성");
            }
            else if(max == 7)
            {
                Debug.Log("위로 속성");
            }
            else if(max == 8)
            {
                Debug.Log("축하 속성");
            }
        }
        else if(type == "color")
        {
            for(int i = 0; i < 6; i++)
            {
                max = 0;
                if(color[i] > max)
                {
                    max = i;
                }
            }

            if(max == 0)
            {
                Debug.Log("빨강 속성");
            }
            else if(max == 1)
            {
                Debug.Log("노랑 속성");
            }
            else if(max == 2)
            {
                Debug.Log("파랑 속성");
            }
            else if(max == 3)
            {
                Debug.Log("보라 속성");
            }
            else if(max == 4)
            {
                Debug.Log("분홍 속성");
            }
            else if(max == 5)
            {
                Debug.Log("하양 속성");
            }
        }
        else if(type == "season")
        {
            for(int i = 0; i < 4; i++)
            {
                max = 0;
                if(season[i] > max)
                {
                    max = i;
                }
            }

            if(max == 0)
            {
                Debug.Log("봄 속성");
            }
            else if(max == 1)
            {
                Debug.Log("여름 속성");
            }
            else if(max == 2)
            {
                Debug.Log("가을 속성");
            }
            else if(max == 3)
            {
                Debug.Log("겨울 속성");
            }
        }
    }
}
