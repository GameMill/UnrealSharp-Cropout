﻿using UnrealSharp;
using UnrealSharp.Attributes;
using UnrealSharp.Engine;

namespace ManagedCropoutSampleProject.Villagers;

[UInterface]
public interface IVillager
{
    [UFunction(FunctionFlags.BlueprintCallable)]
    public void Action(AActor? actor);

    [UFunction(FunctionFlags.BlueprintCallable)]
    public void ChangeJob(FName newJob);

    [UFunction(FunctionFlags.BlueprintCallable)]
    public float PlayDeliverAnim();

    [UFunction(FunctionFlags.BlueprintCallable)]
    public void PlayWorkAnim(float delay);

    [UFunction(FunctionFlags.BlueprintCallable)]
    public float ProgressBuilding(float timeRemaining);

    [UFunction(FunctionFlags.BlueprintCallable)]
    public void ReturnToDefaultBT();
}