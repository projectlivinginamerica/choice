using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class ColorChangeTest : MonoBehaviour
{
    [SerializeField] private TMP_Text TextField;
    [SerializeField] private UnityEngine.Color Color1;
    [SerializeField] private UnityEngine.Color Color2;
    [SerializeField] private float BlendTime = 2.0f;

    private float StartBlendTime;
    private bool ReverseBlendDirection = false;

    // Start is called before the first frame update
    void Start()
    {
        StartBlendTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float curTime = Time.time;
        float t = Mathf.Clamp01((curTime - StartBlendTime) / BlendTime);

        UnityEngine.Color color;
        if (ReverseBlendDirection)
        {
            color = UnityEngine.Color.Lerp(Color2, Color1, t);
        }
        else
        {
            color = UnityEngine.Color.Lerp(Color1, Color2, t);
        }

        if (t == 1.0f)
        {
            ReverseBlendDirection = !ReverseBlendDirection;
            StartBlendTime = Time.time;
        }

        TextField.color = color;
    }
}
