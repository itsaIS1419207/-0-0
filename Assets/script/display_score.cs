using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display_score : MonoBehaviour
{

        public Text m_MyText;

    // Start is called before the first frame update
    void Start()
    {
        m_MyText.text = hold_score.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
