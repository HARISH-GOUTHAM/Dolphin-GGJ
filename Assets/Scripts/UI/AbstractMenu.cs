using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractMenu : MonoBehaviour
{
    public GameObject currentUI;
    public AbstractMenu parent;
    public List<AbstractMenu> children;

    public bool inMenu;

    public void GoToParent()
    {
        if (parent != null)
        {
            parent.currentUI.SetActive(true);
            currentUI.SetActive(false);
        }
        else
        {
          
            currentUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
        
    public void GoToChild(int index)
    {
        children[index].currentUI.SetActive(true);
        children[index].parent = this;
        currentUI.SetActive(false) ;

    }
   
}
