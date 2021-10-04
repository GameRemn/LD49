using System;
using UnityEngine;

public class TextMeshUpdater : TextUpdaterBase<TextMesh>
{
    public override void UpdateText()
    {
        textComponent.text = String.Format(format, texts);
    }
}
