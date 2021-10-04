using System;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

public class UITextUpdater : TextUpdaterBase<Text>
{
    public override void UpdateText()
    {
        textComponent.text = String.Format(format, texts);
    }
}
