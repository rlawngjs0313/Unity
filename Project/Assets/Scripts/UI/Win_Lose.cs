using UnityEngine;
using UnityEngine.UI;

public class Win_Lose : MonoBehaviour
{
    public Text win_lose;
    public GameObject texts;
    Core core;
    private void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
        texts.SetActive(false);
    }
    private void Update()
    {
        
    }
    void winning()
    {
        if(core.score == 3)
        {
            Debug.Log(("D"));
            win_lose.text = "You Win";
            texts.SetActive(true);
        }
        if(core.score < 0)
        {
            win_lose.text = "You Lose";
            texts.SetActive(true);
        }
    }
}