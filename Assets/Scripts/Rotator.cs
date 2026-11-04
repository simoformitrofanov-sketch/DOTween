using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private const int InfiniteLoops = -1;

    [SerializeField] private Vector3 _rotation = new Vector3(0f, 360f, 0f);
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        transform.DORotate(_rotation, _duration, RotateMode.FastBeyond360)
            .SetRelative()
            .SetEase(Ease.Linear)
            .SetLoops(InfiniteLoops, LoopType.Restart)
            .SetLink(gameObject);
    }
}