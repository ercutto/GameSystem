
using TMPro;
using UnityEngine;

public class Sound_Settings : MonoBehaviour
{
   
    public AudioClip[] _audioClip;
    private AudioClip _currentClip;
    public AudioSource _audioSource;
    public TMP_Dropdown _settingDropDown;
    public void HandleInputData()
    {
        
        int val=_settingDropDown.value;
        Debug.Log(val);
        _audioSource.clip = null;
        if (val == 0)
        {
            _currentClip = _audioClip[0];
            _audioSource.clip= _currentClip;
            _audioSource.Play();
        }
        else if (val == 1)
        {

            _currentClip = _audioClip[1];
            _audioSource.clip= _currentClip;
            _audioSource.Play();
        }
        else if (val == 2)
        {
            
                _currentClip = _audioClip[2];
            _audioSource.clip= _currentClip;
            _audioSource.Play();
        }

            
           


    }
}
