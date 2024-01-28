using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolphinTasks : MonoBehaviour
{
    
    private List<GameObject> stikes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Strike(int i)
    {
        stikes[i].SetActive(true);
    }
    
}
