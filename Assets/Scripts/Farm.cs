using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class Farm : MonoBehaviour
{
    public int count = 0;
    string seedname = null;
    GameManager gm;
    int FarmCount;
    public bool water = false;
    Text seedText;
    FarmDirector fd;

    public void FarmButton(string flowername)
    {
        if (count == 0)//씨뿌리기
        {
            count = 1;
            seedname = flowername;
            seedText.text = seedname;
            GetComponent<Image>().sprite = fd.inFarm;
        }
       else if(count > 1)//수확 이틀걸림
        {
            for(int num = 0; num < 13; num++)
            {
                if(seedText.text == gm.flower[num].name)
                {
                    gm.flower[num].count += 3;
                    if (!gm.flower[num].get)
                    {
                        gm.flower[num].get = true;
                    }

                    break;
                }
            }
            count = 0;
            seedname = null;
            seedText.text = "";
            GetComponent<Image>().sprite = fd.notinFarm;
            GetComponent<Image>().color = new Color32(255,255,255, 255);
        }
        else//물주기
        {
            if (fd.WaterCount > 0 && !this.water)
            {
                fd.WaterCount--;
                GetComponent<Image>().color = new Color32(150, 180, 200, 255);
                GetComponent<Farm>().water = true;
                count++;
                water = true;
            }
        }
        /*Debug.Log(FarmCount);
        Debug.Log(count);
        Debug.Log(seedname);*/
    }
    // Start is called before the first frame update
    void Start()
    {
        string namecount = Regex.Replace(gameObject.name, @"\D", "");
        FarmCount = int.Parse(namecount) - 1;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        fd = GameObject.Find("FarmDirector").GetComponent<FarmDirector>();
        this.count = gm.farm[FarmCount].count;
        this.seedname = gm.farm[FarmCount].name;
        this.water = gm.farm[FarmCount].water;

        seedText = gameObject.transform.GetChild(0).GetComponent<Text>();
        if (!(seedname == null))
        {
            seedText.text = seedname;
        }

    }
        // Update is called once per frame
        void Update()
    {
        

    }
}
