using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameOver : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI]GameOver;
    // Start is called before the first frame update
    void Start()
    {
        GameOverTxt.text ="GameOver"
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -5.0f)
        {
            Destroy(this.gameObject);
            GameOverText.text = "GameOver";
        }
        
    }
}
