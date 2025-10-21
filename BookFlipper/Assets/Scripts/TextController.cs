using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
public class TextController : MonoBehaviour
{
    TMP_Text tmpText;
    Coroutine coroutine; 
    private float textDelay = 0.01f;
    private float textDisplayDelay = 1.0f;
    [SerializeField] byte r;
    [SerializeField] byte g;
    [SerializeField] byte b;
    private void Awake()
    {
        tmpText = GetComponent<TMP_Text>();
        Color32 color = new Color32(0, 0, 0, 0);
        tmpText.color = color;
        tmpText.gameObject.SetActive(false);
    }
  
    IEnumerator ColorCharacters()
    {
        tmpText.ForceMeshUpdate();
        var textInfo = tmpText.textInfo;
        yield return new WaitForSeconds(textDisplayDelay);

        for (int i = 0; i < textInfo.characterCount; i++)
        {
            var charInfo = textInfo.characterInfo[i];
            if (!charInfo.isVisible) continue; 

            int vertexIndex = charInfo.vertexIndex;
            int materialIndex = charInfo.materialReferenceIndex;
            Color32[] vertexColors = textInfo.meshInfo[materialIndex].colors32;

            Color32 newColor = new Color32(r, g, b, 255);

            vertexColors[vertexIndex + 0] = newColor;
            vertexColors[vertexIndex + 1] = newColor;
            vertexColors[vertexIndex + 2] = newColor;
            vertexColors[vertexIndex + 3] = newColor;

            tmpText.UpdateVertexData(TMP_VertexDataUpdateFlags.Colors32);

            yield return new WaitForSeconds(textDelay); 
        }
    }
    private void OnEnable()
    {
        coroutine = StartCoroutine(ColorCharacters());

    }
}
