using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    private const int InfiniteLoops = -1;

    [SerializeField] private Vector3 _targetScale = new Vector3(1.5f, 1.5f, 1.5f);
    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(InfiniteLoops, LoopType.Yoyo)
            .SetLink(gameObject);
    }
}