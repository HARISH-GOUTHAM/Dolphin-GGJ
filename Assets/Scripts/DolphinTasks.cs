using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DolphinTasks : MonoBehaviour
{
    
    [SerializeField]private List<GameObject> stikes = new List<GameObject>();
    public GameObject taskMenu;
    public static DolphinTasks Instance;
    
    private void Awake()
    {
        Instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) ||Gamepad.current!=null && Gamepad.current.selectButton.wasPressedThisFrame)
            taskMenu.SetActive(!taskMenu.activeSelf);
        
    }

    public void Strike(int i)
    {
        stikes[i].SetActive(true);
    }
    
}
