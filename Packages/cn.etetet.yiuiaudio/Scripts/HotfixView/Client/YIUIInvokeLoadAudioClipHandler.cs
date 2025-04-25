using UnityEngine;

namespace ET.Client
{
    [Invoke(EYIUIInvokeType.Sync)]
    public class YIUIInvokeLoadAudioClipSyncHandler : AInvokeHandler<YIUIInvokeLoadAudioClip, AudioClip>
    {
        public override AudioClip Handle(YIUIInvokeLoadAudioClip args)
        {
            var resName = args.ResName;

            if (YIUILoadComponent.Inst == null) return null;

            #if UNITY_EDITOR
            if (!YIUILoadComponent.Inst.VerifyAssetValidity(resName))
            {
                Log.Error($"验证资产有效性 没有这个资源 无法加载 请检查 {resName}");
                return null;
            }
            #endif

            var audioClip = YIUILoadComponent.Inst.LoadAsset<AudioClip>(resName);

            if (audioClip == null)
            {
                Log.Error($"加载失败 没有这个资源 无法加载 请检查 {resName}");
                return null;
            }

            return audioClip;
        }
    }

    [Invoke(EYIUIInvokeType.Async)]
    public class YIUIInvokeLoadAudioClipAsyncHandler : AInvokeHandler<YIUIInvokeLoadAudioClip, ETTask<AudioClip>>
    {
        public override async ETTask<AudioClip> Handle(YIUIInvokeLoadAudioClip args)
        {
            if (YIUILoadComponent.Inst == null) return null;
            var resName = args.ResName;
            #if UNITY_EDITOR
            if (!YIUILoadComponent.Inst.VerifyAssetValidity(resName))
            {
                Log.Error($"验证资产有效性 没有这个资源 无法加载 请检查 {resName}");
                return null;
            }
            #endif

            var audioClip = await YIUILoadComponent.Inst.LoadAssetAsync<AudioClip>(resName);

            if (audioClip == null)
            {
                Log.Error($"加载失败 没有这个资源 无法加载 请检查 {resName}");
                return null;
            }

            return audioClip;
        }
    }
}