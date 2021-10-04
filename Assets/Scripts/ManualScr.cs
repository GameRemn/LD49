using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualScr : MonoBehaviour
{
    [SerializeField] List<GameObject> instructText;
    [SerializeField] List<GameObject> lightBatton;
    public void CloseAll()
    {
        foreach (GameObject i in instructText)
        {
            i.SetActive(false);
        }
        foreach (GameObject i in lightBatton)
        {
            i.SetActive(false);
        }

    }
}
