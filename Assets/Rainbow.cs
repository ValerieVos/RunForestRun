using UnityEngine;

public class Rainbow : MonoBehaviour
{
    // Change colors of material by shifting over hue value for certain duration 

    float duration = 5.0f;
    SkinnedMeshRenderer renderer;

    void Start()
    {
        renderer = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    void Update()
    {
        float hue = Mathf.PingPong(Time.time, duration) / duration;
        renderer.material.color = Color.HSVToRGB(hue, 1.0f, 1.0f);
    }
}