using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeinScene : MonoBehaviour
{
    public Image fadeFromImage;
    public float fadeinSpeed = .3f;
    
    
    private void Start()
    {
        StartCoroutine("FadeToWhite");
    }

    private IEnumerator FadeToWhite()
    { 
        var c = new Color(0f,0f,0f,1f);

        while (c.a > 0.009f)
        {
            c.a -= Math.Abs(Time.deltaTime * fadeinSpeed);
            fadeFromImage.color = c;

            yield return null;
        }

        yield return null;
    }

}
