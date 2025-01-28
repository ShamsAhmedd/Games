using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    [SerializeField]
    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    // Update is called once per frame
    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(0.7f);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        countDownGo.SetActive(true);

    }
    
}
