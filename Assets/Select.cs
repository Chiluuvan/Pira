using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    void Start()
    {

    }
    void UpdateText()
    { }
    // Update is called once per frame
    void Update()
    {

    }
    public List<GameObject> ga = new List<GameObject>();
    public void Sel(int t)
    {
        ga[t].SetActive(true);
        GameManager.instance.Coin = t;
    }
}
