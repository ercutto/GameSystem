using UnityEngine;

public abstract class SoundBase 
{
    public abstract void Enter(SoundStateManager sound);
    public abstract void UpdateState(SoundStateManager sound);
    public abstract void EaseSound(SoundStateManager sound);
    public abstract void UpVolume(SoundStateManager sound);
}
