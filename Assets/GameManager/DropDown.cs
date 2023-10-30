using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public AudioClip[] _audioClip;
    private AudioClip _currentClip;
    public AudioSource _audioSource;
    public TMPro.TMP_Dropdown settingDropDown;
    public void HandleInputData()
    {
        int val= settingDropDown.value;
        Debug.Log(val);
        _currentClip = _audioClip[val];
        _audioSource.clip = _currentClip;

        //_audioSource.PlayOneShot(_currentClip);


    }
}
