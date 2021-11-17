using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tools : MonoBehaviour
{
    public CanvasRenderer fade;
    

    // Start is called before the first frame update
    void Start()
    {
        StopAllCoroutines();
        StartCoroutine(Fade(0, 3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade(float endValue, float duration, string scene = null)
    {
        float time = 0;
        
        float startValue = fade.GetAlpha();

        if (startValue >  endValue)
            yield return new WaitForSeconds(1.0f);

        while (time < duration)
        {
            fade.SetAlpha(Mathf.Lerp(startValue, endValue, time / duration));

            time += Time.deltaTime;
            yield return null;
        }
        fade.SetAlpha(endValue);
        if (scene != null)
        {
            SceneManager.LoadScene(scene);
        }
    }

    public void mez()
    {
        StopAllCoroutines();
        StartCoroutine(Fade(1, 3, "Mez"));
    }

    public void liv()
    {
        StopAllCoroutines();
        StartCoroutine(Fade(1, 3, "360VideoTour"));
    }

    public void cube()
    {
        StopAllCoroutines();
        StartCoroutine(Fade(1, 3, "Cube"));
    }

    public void can()
    {
        StopAllCoroutines();
        StartCoroutine(Fade(1, 3, "Cantina"));
    }
}
