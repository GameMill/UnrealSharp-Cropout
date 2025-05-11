﻿using UnrealSharp;
using UnrealSharp.Attributes;
using UnrealSharp.Attributes.MetaTags;
using UnrealSharp.Engine;
using UnrealSharp.UMG;

namespace ManagedCropoutSampleProject.UI;

[UClass]
public class UTransitionWidget : UUserWidget
{
    [UProperty(PropertyFlags.Transient), BindWidgetAnim]
    public UWidgetAnimation FadeAnimation { get; set; }

    public void TransitionIn()
    {
        PlayAnimation(FadeAnimation);
    }
    
    public void TransitionOut()
    {
        PlayAnimation(FadeAnimation, 0.0f, 0, EUMGSequencePlayMode.Reverse);

        [UFunction]
        void OnTransitionInFinished()
        {
            RemoveFromParent();
        }
        
        SystemLibrary.Delay(FadeAnimation.EndTime, new FLatentActionInfo(OnTransitionInFinished));
    }
}