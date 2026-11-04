using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private const int InfiniteLoops = -1;

    [SerializeField] private Vector3 _offset = new Vector3(3f, 0f, 0f);
    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        transform.DOMove(transform.position + _offset, _duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(InfiniteLoops, LoopType.Yoyo)
            .SetLink(gameObject);
    }
}