using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class PedalsTrigger : EventTrigger
{
    public event Action<bool> pointerUp;
    public event Action<bool> pointerDown;

    public override void OnPointerUp(PointerEventData data)
    {
        pointerUp?.Invoke(false);
    }

    public override void OnPointerDown(PointerEventData data)
    {
        pointerDown?.Invoke(false);
    }
}
