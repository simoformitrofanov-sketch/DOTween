using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    private const int InfiniteLoops = -1;

    [SerializeField] private Color _targetColor = Color.red;
    [SerializeField] private float _duration = 2f;

    private Material _material;
    private Tween _tween;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        _tween = _material.DOColor(_targetColor, _duration)
            .SetEase(Ease.InOutSine)
            .SetLoops(InfiniteLoops, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        _tween.Kill();
        Destroy(_material);
    }
}