using UnityEngine;
using UnityEngine.UI;

public class WaveProgress : MonoBehaviour
{
    public Image backgroundImage;
    public Image fillImage;

    public float timeToFillInSeconds = 3;

    private int? currentPointerID;

    public bool TryShow(int pointerID, Vector3 position)
    {
        if (currentPointerID.HasValue)
            return false;

        Show(position);

        currentPointerID = pointerID;
        return true;
    }

    public bool TryHide(int pointerID)
    {
        if (currentPointerID.HasValue && currentPointerID.Value == pointerID)
        {
            currentPointerID = null;

            Hide();

            return true;
        }

        return false;
    }

    void Show(Vector3 position)
    {
        ((RectTransform) transform).anchoredPosition = position;
        gameObject.SetActive(true);

        fillImage.fillAmount = 0;
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        float fillAmt = fillImage.fillAmount;

        fillAmt += (1 / timeToFillInSeconds) * Time.deltaTime;

        fillImage.fillAmount = fillAmt;

        if (fillAmt >= 1)
            Hide();
    }
}
