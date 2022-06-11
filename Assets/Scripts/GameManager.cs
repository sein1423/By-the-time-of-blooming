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

    public Illustrated illust;
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

    public flowerstate[] flower = new flowerstate[13];
    public farmstate[] farm = new farmstate[9];
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

    // Update is called once per frame
    void Update()
    {
        
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

}
