using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MakeManager : MonoBehaviour
{
    public Button btnCa, btnDa, btnDe, btnEu, btnFr, btnGl, btnJa, btnMa, btnRo, btnSs, btnSu, btnVi, btnYa, btnNext, btnCom;   //꽃 선택 버튼
    public Button btnRad, btnGreen, btnOrang, btnBlue, btnPurple;    //꽃다발 색깔 버튼
    public GameObject G_btnCa, G_btnDa, G_btnDe, G_btnEu, G_btnFr, G_btnGl, G_btnJa, G_btnMa, G_btnRo, G_btnSs, G_btnSu, G_btnVi, G_btnYa, G_btnNext, G_btnCom;
    public GameObject G_btnRad, G_btnGreen, G_btnOrang, G_btnBlue, G_btnPurple;
    public GameObject carnation_pre, daisy_pre, del_pre, eun_pre, freesia_pre, glra_pre, jahng_pre, marry_pre, rose_pre, ssug_pre, susun_pre, violet_pre, yang_pre;     //꽃 프리팹
    public GameObject radt_pre, orangt_pre, greent_pre, bluet_pre, puplet_pre, radb_pre, orangb_pre, greenb_pre, blueb_pre, pupleb_pre;     //꽃다발 프리팹
    int max = 4;        //꽃 최대 개수
    int count = 0;      //꽃 개수
    float px = 0, py = 0;     //꽃 위치 변수
    int rx = 0, ry =0;      //꽃 회전 변수
    int layer = 0;      //레이어 위치
    int[] language = new int[9] { 0,0,0,0,0,0,0,0,0};    //꽃말 속성      배열값 순서 :love, happy, friendship, secret, free, narcissism, longing, consolation, thank
    int[] color = new int[6] { 0,0,0,0,0,0};       //꽃 색깔 속성  배열값 순서 : rad, yellow, blue, purple, pink, white;
    int[] season = new int[4] {0,0,0,0};      //꽃 계절 속성  배열값 순서: 봄,여름,가을,겨울
    GameManager gm;

    

    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        
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

       
        
        
        //꽃 소지개수에 
        

    }

    // Update is called once per frame
     void Update()
    {
        
    }

     void btnCa_clik()      //카네이션 버튼 클릭 함수
    {
        if(count <= max && gm.flower[11].count>0){
            GameObject carnation = Instantiate(carnation_pre) as GameObject;        //카네이션 오브젝트 생성
            pos(count);     //꽃 위치 정하기
            carnation.transform.position = new Vector3(px,py,0);        //카네이션 위치
            carnation.transform.SetSiblingIndex(layer);                 //카네이션 레이어 위치 였는데 안댐...
            count++;
            gm.flower[11].count--;
            //속성
            language[8]++;
            color[0]++;
            season[1]++;
        }
                //꽃 개수 세기
    }
    void btnDa_clik()
    {
        if(count <= max && gm.flower[1].count > 0)
        {
            GameObject dai = Instantiate(daisy_pre) as GameObject;
            pos(count);
            dai.transform.position = new Vector3(px,py,0);
            dai.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[1].count--;
            //속성
            language[0]++;
            color[5]++;
            season[0]++;
        }
        
    }
    void btnDe_clik()
    {
        if(count <= max && gm.flower[2].count > 0)
        {
            GameObject del = Instantiate(del_pre) as GameObject;
            pos(count);
            del.transform.position = new Vector3(px,py,0);
            del.transform.SetSiblingIndex(layer);
            count++; 
            gm.flower[2].count--;
            //속성
            language[4]++;
            color[2]++;
            season[0]++;
        }
        
    }
    void btnEu_clik()
    {
        if(count <= max && gm.flower[8].count > 0)
        {
            GameObject eun = Instantiate(eun_pre) as GameObject;
            pos(count);
            eun.transform.position = new Vector3(px,py,0);
            eun.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[8].count--;
            //속성
            language[1]++;
            color[5]++;
            season[0]++;

        }
        
        
    }
    void btnFr_clik()
    {
        if(count <= max && gm.flower[12].count > 0)
        {
            GameObject fre = Instantiate(freesia_pre) as GameObject;
            pos(count);
            fre.transform.position = new Vector3(px,py,0);
            fre.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[12].count--;
            //속성
            language[2]++;
            color[1]++;
            season[0]++;
        }
        
    }




    void btnGl_clik()
    {
        if(count <= max && gm.flower[0].count > 0)
        {
            GameObject glr = Instantiate(glra_pre) as GameObject;
            pos(count);
            glr.transform.position = new Vector3(px,py,0);
            glr.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[0].count--;
            //속성
            language[3]++;
            color[0]++;
            season[1]++;
        }
        
    }
    void btnJa_clik()
    {
        if(count <= max && gm.flower[9].count > 0)
        {
            GameObject jah = Instantiate(jahng_pre) as GameObject;
            pos(count);
            jah.transform.position = new Vector3(px,py,0);
            jah.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[9].count--;
            //속성
            language[0]++;
            color[4]++;
            season[2]++;
        }
        
    }
    void btnMa_clik()
    {
        if(count <= max && gm.flower[5].count > 0)
        {
            GameObject mar = Instantiate(marry_pre) as GameObject;
            pos(count);
            mar.transform.position = new Vector3(px,py,0);
            mar.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[5].count--;
            //속성
            language[1]++;
            color[1]++;
            season[1]++;
        }
        
    }
    void btnRo_clik()
    {
        if(count <= max && gm.flower[10].count > 0)
        {
            GameObject ros = Instantiate(rose_pre) as GameObject;
            pos(count);
            ros.transform.position = new Vector3(px,py,0);
            ros.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[10].count--;
            //속성
            language[0]++;
            color[0]++;
            season[1]++;
        }
        
    }
    void btnSs_clik()
    {
        if(count <= max && gm.flower[6].count > 0)
        {
            GameObject Ssu = Instantiate(ssug_pre) as GameObject;
            pos(count);
            Ssu.transform.position = new Vector3(px,py,0);
            Ssu.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[6].count--;
            //속성
            language[6]++;
            color[3]++;
            season[2]++;
            
        }
        
    }



    void btnSu_clik()
    {
        if(count <= max && gm.flower[4].count > 0)
        {
            GameObject sus = Instantiate(susun_pre) as GameObject;
            pos(count);
            sus.transform.position = new Vector3(px,py,0);
            sus.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[4].count--;
            //속성
            language[5]++;
            color[1]++;
            season[3]++;
        }
        
    }
    void btnVi_clik()
    {
        if(count <= max && gm.flower[3].count > 0)
        {
            GameObject vio = Instantiate(violet_pre) as GameObject;
            pos(count);
            vio.transform.position = new Vector3(px,py,0);
            vio.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[3].count--;
            //속성
            language[2]++;
            color[3]++;
            season[0]++;
        }
        
    }
    void btnYa_clik()
    {
        if(count <= max && gm.flower[7].count > 0)
        {
            GameObject yan = Instantiate(yang_pre) as GameObject;
            pos(count);
            yan.transform.position = new Vector3(px,py,0);
            yan.transform.SetSiblingIndex(layer);
            count++;
            gm.flower[7].count--;
            //속성
            language[7]++;
            color[0]++;
            season[1]++;
        }
        
    }


    //꽃다발 선택
    void btnRad_clik()
    {
        GameObject Rt = Instantiate(radt_pre) as GameObject;
        GameObject Rb = Instantiate(radb_pre) as GameObject;
    }

    void btnOrang_clik()
    { 
        GameObject Ot = Instantiate(orangb_pre) as GameObject;
        GameObject Ob = Instantiate(orangt_pre) as GameObject;
    }

    void btnGreen_clik()
    {
        GameObject Gt = Instantiate(greenb_pre) as GameObject;
        GameObject Gb = Instantiate(greent_pre) as GameObject;
    }

    void btnBlue_clik()
    {
        GameObject Bt = Instantiate(blueb_pre) as GameObject;
        GameObject Bb = Instantiate(bluet_pre) as GameObject;
    }

    void btnPurple_clik()
    {
        GameObject Pt = Instantiate(pupleb_pre) as GameObject;
        GameObject Pb = Instantiate(puplet_pre) as GameObject;
    }

    
    void btnNext_clik()     //다음 버튼 클릭
    {
        bool flower_btn = false;
        bool color_btn = true;
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

    }


    //완료 버튼 누르면.....
    void btnCom_clik()
    {
        score();
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
    void score()
    {
        string lang="",col="",sea="";
        int langmax = 0, colmax = 0, seamax = 0;
        if(true)
        {
            max = 0;
            for (int i = 0; i < 9; i++)
            {
                if(language[i] > max)
                {
                    max = language[i];
                    langmax = i;
                }
            }

            if(langmax == 0)
            {
                lang = "사랑";
            }
            else if(langmax == 1)
            {
                lang = "행복";
            }
            else if(langmax == 2)
            {
                lang = "우정";
            }
            else if(langmax == 3)
            {
                lang = "비밀";
            }
            else if(langmax == 4)
            {
                lang = "자유";
            }
            else if(langmax == 5)
            {
                lang = "자기애";
            }
            else if(langmax == 6)
            {
                lang = "그리움";
            }
            else if(langmax == 7)
            {
                lang = "위로";
            }
            else if(langmax == 8)
            {
                lang = "축하";
            }
        }

        if(true)
        {
            max = 0;
            for (int i = 0; i < 6; i++)
            {
                if(color[i] > max)
                {
                    max = color[i];
                    colmax = i;
                }
            }

            if(colmax == 0)
            {
                col = "red";
            }
            else if(colmax == 1)
            {
                col = "yellow";
            }
            else if(colmax == 2)
            {
                col = "blue";
            }
            else if(colmax == 3)
            {
                col = "purple";
            }
            else if(colmax == 4)
            {
                col = "pink";
            }
            else if(colmax == 5)
            {
                col = "white";
            }
        }

        if(true)
        {
            max = 0;
            for (int i = 0; i < 4; i++)
            {
                if(season[i] > max)
                {
                    max = season[i];
                    seamax = i;
                }
            }

            if(seamax == 0)
            {
                sea = "spring";
            }
            else if(seamax == 1)
            {
                sea = "summer";
            }
            else if(seamax == 2)
            {
                sea = "fall";
            }
            else if(seamax == 3)
            {
                sea = "winter";
            }
        }

        Debug.Log($"{lang} 속성, {col}색, 계절 : {sea}");
        gm.bou1.lang = lang;
        gm.bou1.color = col;
        gm.bou1.season = sea;
        SceneManager.LoadScene("counter");
    }
}
