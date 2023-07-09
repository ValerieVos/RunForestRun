using UnityEngine;

public class Rainbow : MonoBehaviour
{
    // Fade the color from red to green
    // back and forth over the defined duration

    Color colorStart = Color.red;
    Color colorEnd = Color.green;
 
    float duration = 5.0f;
    SkinnedMeshRenderer rend;

    void Start()
    {
        rend = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    void Update()
    {
        float hue = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.HSVToRGB(hue, 1.0f, 1.0f);
    }
}