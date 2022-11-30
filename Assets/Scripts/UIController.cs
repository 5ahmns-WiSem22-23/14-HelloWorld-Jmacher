using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    string fieldText, labelText;

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0,0,Screen.width,Screen.height));
        GUILayout.FlexibleSpace();
        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.BeginVertical();

        fieldText = GUILayout.TextField(fieldText, GUILayout.Width(300));
        if (GUILayout.Button("Next", GUILayout.Width(300))) labelText = fieldText;
        GUILayout.Box(labelText, GUILayout.Width(300));

        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.FlexibleSpace();
        GUILayout.EndArea();
    }
}
