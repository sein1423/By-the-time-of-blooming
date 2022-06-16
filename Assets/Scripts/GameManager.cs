using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }
    public float money = 0;
    public Illustrated illust;
    public struct bouquet 
    {
        public string lang;
        public string color;
        public string season;
    }
    public struct flowerstate{
        public string name;
        public bool get;
        public int count;
    }

    public struct farmstate
    {
        public string name;
        public int count;
        public bool water;
    }

    public bouquet bou1 = new bouquet { lang = "", color = "", season = ""};
    public flowerstate[] flower = new flowerstate[13];
    public farmstate[] farm = new farmstate[9];
    public int dayCount = 1;
    //나중에 Int랑 속성값 추가하기
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else if(_instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {

        flower[0].name = "글라디올러스";
        flower[1].name = "데이지";
        flower[2].name = "델피늄";
        flower[3].name = "바이올렛";
        flower[4].name = "수선화";
        flower[5].name = "메리골드";
        flower[6].name = "쑥부쟁이";
        flower[7].name = "양귀비";
        flower[8].name = "은방울꽃";
        flower[9].name = "자홍색 국화";
        flower[10].name = "장미";
        flower[11].name = "카네이션";
        flower[12].name = "프리지아";
        for (int count = 0; count < 13; count++)
        {
            flower[count].get = false;
            flower[count].count = 0;
        }
        for (int count = 0; count < 9; count++)
        {
            farm[count].name = null;
            farm[count].water = false;
            farm[count].count = 0;
        }
    }


    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "illustrated")
        {
            illust = GameObject.Find("illustratedManager").GetComponent<Illustrated>();
        }
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void NextDay()
    {
        for(int count = 0; count < 9; count++)
        {
            farm[count].water = false;
        }
        dayCount++;
    }

}
