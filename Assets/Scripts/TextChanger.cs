using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    private const int InfiniteLoops = -1;

    [SerializeField] private string _replacementText = "Вот такачка";
    [SerializeField] private string _addedText = ", соба хня!";
    [SerializeField] private string _scrambledText = "Вот такие дела, собачка! :)";
    [SerializeField] private float _duration = 2f;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_replacementText, _duration)
            .SetEase(Ease.Linear));

        sequence.Append(_text.DOText(_addedText, _duration)
            .SetRelative()
            .SetEase(Ease.Linear));

        sequence.Append(_text.DOText(
                _scrambledText, _duration, scrambleMode: ScrambleMode.All)
            .SetEase(Ease.Linear));

        sequence.SetLoops(InfiniteLoops, LoopType.Restart)
            .SetLink(gameObject);
    }
}