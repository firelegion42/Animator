using DG.Tweening;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    [SerializeField] private float scaleFactor;

    private Vector3 currentScale;

    private void Start()
    {
        currentScale = transform.localScale;
    }

    public void Shrink()
    {
        transform.DOScale(transform.localScale * scaleFactor, 1.5f);
    }
}
