using UnityEngine;
using UnityEngine.UI;

public class Win_Lose : MonoBehaviour
{
    public Text win;
    public Text lose;
    Core core;
    private void Start()
    {
        core = GameObject.Find("GameSystem").GetComponent<Core>();
    }
    private void Update()
    {
        
    }
    void winning()
    {
        if(core.score == 3)
        {
            win.text = "You Win";
        }
        if(core.score < 0)
        {
            lose.text = "You Lose";
        }
    }
}