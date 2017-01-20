
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public WaveProgress[] waveProgresses;

    public void OnPointerDown(PointerEventData eventData)
    {
        for (int x = 0; x < waveProgresses.Length; x++)
        {
            Vector2 localPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(((RectTransform) transform), eventData.position, Camera.main, out localPos);

            if (waveProgresses[x].TryShow(eventData.pointerId, localPos))
                return;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        for (int x = 0; x < waveProgresses.Length; x++)
        {
            if (waveProgresses[x].TryHide(eventData.pointerId))
                return;
        }
    }
}
