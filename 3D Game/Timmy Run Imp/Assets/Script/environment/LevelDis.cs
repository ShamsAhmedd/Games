using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class LevelDis : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;
    private void Start()
    {
        disRun = -10;

    }
    private void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
       


    }
    IEnumerator AddingDis()
    {
        disRun += 10;
        disDisplay.GetComponent<TextMeshProUGUI>().text = "" + disRun + " M";
        yield return new WaitForSeconds(0.25f);
        addingDis = false;
    }
   

}