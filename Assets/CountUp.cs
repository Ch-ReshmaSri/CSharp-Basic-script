using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CountUp : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI[] Texts;
    [SerializeField]
    private float Speed = 1;
    private float TimeDisplay = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Speed > 0)
        {
            TimeDisplay = TimeDisplay + Time.deltaTime * Speed;
            //Text.SetText(TimeDisplay.ToString("N2"));
            for (int i =0; i < Texts.Length; i++)
            {
                Texts[i].SetText($"{TimeDisplay.ToString("N2")}");
            }
        }
    }
}
