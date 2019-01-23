using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeoutSceneChange : MonoBehaviour
{
    public Image fadeToImage;
    public float fadeoutAfterSeconds = 3f;
    
    
    private void Start()
    {
        StartCoroutine("FadeToBlack");
    }

    private IEnumerator FadeToBlack()
    {
        yield return new WaitForSeconds(fadeoutAfterSeconds);
        
        var c = new Color(0f,0f,0f,0f);

        while (c.a <= 1f)
        {
            c.a += Math.Abs(Time.deltaTime * 2);
            fadeToImage.color = c;

            Debug.Log("Color alpha = " + fadeToImage.color.a);
            yield return null;
        }

        SceneManager.LoadScene(1);

        yield return null;
    }

}
