using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AutoDestoryText : MonoBehaviour
{
    public float AutoDestroyTime = 5f;
    private TextMeshProUGUI Text;
    private float SpawnTime;
    // Start is called before the first frame update
    private void Awake()
    {
        Text = GetComponent<TextMeshProUGUI>();
        AutoDestroyTime = 5f;
    }
    private void OnEnable()
    {
        SpawnTime = Time.time;
    }
    private void Update()
    {
        float remainingTime = (SpawnTime + AutoDestroyTime) - Time.time;
        Text.SetText($"{remainingTime:N2}");
        if (remainingTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
