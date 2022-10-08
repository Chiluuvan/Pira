using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void load(int s)
    {
        SceneManager.LoadScene(s, LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
