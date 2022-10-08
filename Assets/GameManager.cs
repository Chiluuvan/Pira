using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TMPro.TMP_Text CoinText;
    public int Coin
    {
        get { return coin; }
        set
        {
            coin = value;
            UpdateText();
        }
    }
    int coin = 0;
    private void Awake()
    {
        instance = this;
        Ind = Random.Range(1,16);
    }
    int Ind = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Animator ani;
    void UpdateText()
    {
        ani.Play("1");
        CoinText.text = coin.ToString();
        if (coin == Ind)
        {
            GameOver();
        }

    }
    public GameObject gameOverBtn;
    public GameObject pirate;
  public   float speed = 50;
    void GameOver()
    {
        pirate.transform.parent = null;
           Rigidbody rig = pirate.GetComponent<Rigidbody>();
        rig.isKinematic = false;
        rig.AddForce(new Vector3(speed*0.2f, speed,0),ForceMode.Impulse);
        rig.AddTorque(new Vector3(10,10,10),ForceMode.Impulse);

     
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
    
        yield return new WaitForSeconds(2);
        gameOverBtn.SetActive(true);
       
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
