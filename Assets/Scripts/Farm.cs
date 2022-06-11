using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Farm : MonoBehaviour
{
    int count = 0;
    string name = null;

    public void FarmButton(string flowername)
    {
       if(count == 0)
        {
            count = 1;
            this.name = flowername;
        }
       else if(count > 2)
        {
            count = 0;
        }
        else
        {
            count++;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
