using UnityEngine;
using UnityEngine.UI;

public class MenuControler : MonoBehaviour
{
    public GameObject endPanel;
    public Text LostState;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void LoseGame()
    {
        endPanel.SetActive(true);
        endPanel.transform.GetChild(0).GetComponent<TextLostState>().Text = "Game over..."
;    }

}
