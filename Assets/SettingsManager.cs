using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class SettingsManager : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;
    public AudioMixer audiomixer;
    Resolution[] resolutions;

    private void Start() {
        resolutions=Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex=0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width+" x "+ resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex=i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value= currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume",volume);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void SetFullScreen (bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    public void SetResolution(int ResolutionIndex)
    {
        Resolution resolution = resolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
    }
}
