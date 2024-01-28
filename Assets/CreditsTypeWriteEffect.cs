using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreditsTypeWriteEffect : MonoBehaviour
{
    public TextMeshProUGUI Credits;
    public float TypeSpeed;
    public string line;


    private void OnEnable()
    {
        LoadCredits();
    }
    public void LoadCredits()
    {
        StartCoroutine(DisplayLine());
    }
    public IEnumerator DisplayLine()
    {
        Credits.text = "";
        foreach (char letter in line)
        {
            Credits.text += letter;
            yield return new WaitForSeconds(TypeSpeed);
        }
    }
}
