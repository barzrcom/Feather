using UnityEngine;

// Starting in 2 seconds.
// a projectile will be launched every 0.3 seconds
public class SkyChanger : MonoBehaviour
{
    public Material[] skies;

    private float _currentSkyIndex = -1;

    void Start()
    {
        InvokeRepeating("LaunchSky", 0.0f, 30.0f);
    }

    void LaunchSky()
    {
        _currentSkyIndex = (_currentSkyIndex + 1) % skies.Length;
        RenderSettings.skybox = skies[(int)_currentSkyIndex];
        DynamicGI.UpdateEnvironment();
    }
}