using System;
using UnityEngine;
using YIUIFramework;

namespace ET
{
    [EnableClass]
    public class AudioClipLoader : IAudioClipLoader
    {
        public void UnloadAudioClip(AudioClip clip)
        {
            EventSystem.Instance?.YIUIInvokeSync(new YIUIInvokeRelease { obj = clip });
        }

        public void LoadAudioClip(string clipName, Action<AudioClip> loadCompleted)
        {
            var audioClip = EventSystem.Instance?.YIUIInvokeSync<YIUIInvokeLoadAudioClip, AudioClip>(new YIUIInvokeLoadAudioClip
            {
                ResName = clipName,
            });

            if (audioClip == null)
            {
                Debug.LogError($"音频: {clipName} 没有找到!");
                return;
            }

            loadCompleted?.Invoke(audioClip);
        }
    }
}