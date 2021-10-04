using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITextMeshProUpdater : TextUpdaterBase<TextMeshProUGUI>
{
    public override void UpdateText()
    {
        textComponent.text = String.Format(format, texts);
    }
}
