using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public static int scoreCount;
    public GameObject scoreDisplay;
    // Update is called once per frame
    void Update()
    {
        scoreDisplay.GetComponent<Text>().text = "" + scoreCount;
    }
}
