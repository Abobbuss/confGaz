using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIQuest : MonoBehaviour
{
    [SerializeField] private Canvas _questCanvas;
    [SerializeField] private TextMeshProUGUI _questionText;
    [SerializeField] private Button[] _answerButtons;
    [SerializeField] private QuestionTBSet _questionSet;
    [SerializeField] private Button _nextQuestion;

    private int _currentQuestionIndex = 0;

    public UnityAction QuizOver;

    private void Start()
    {
        _questCanvas.enabled = false;
        _nextQuestion.gameObject.SetActive(false);
    }

    public void StartUIQuest()
    {
        _questCanvas.enabled = true;
        DisplayQuestion(0);
    }

    private void DisplayQuestion(int index)
    {
        _questionText.text = _questionSet.questions[index].questionText;

        for (int i = 0; i < _answerButtons.Length; i++)
        {
            SetButtonColors(_answerButtons[i], Color.white);

            _answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = _questionSet.questions[index].answers[i].answerText;

            int currentIndex = i;
            _answerButtons[i].onClick.RemoveAllListeners();
            _answerButtons[i].onClick.AddListener(() => OnAnswerSelected(currentIndex));
        }
    }

    private void OnAnswerSelected(int selectedAnswerIndex)
    {
        if (selectedAnswerIndex != _questionSet.questions[_currentQuestionIndex].correctAnswerIndex)
        {
            SetButtonColors(_answerButtons[selectedAnswerIndex], Color.red);
        }
        else
        {
            SetButtonColors(_answerButtons[selectedAnswerIndex], Color.green);

            _nextQuestion.gameObject.SetActive(true);
            _nextQuestion.onClick.RemoveAllListeners();
            _nextQuestion.onClick.AddListener(() => NextQuestion());
        }
    }

    private void NextQuestion()
    {
        Debug.Log(_currentQuestionIndex);
        _currentQuestionIndex++;

        if (_currentQuestionIndex < _questionSet.questions.Length)
            DisplayQuestion(_currentQuestionIndex);
        else
            QuizEnd();

        _nextQuestion.gameObject.SetActive(false);
    }

    private void SetButtonColors(Button button, Color color)
    {
        ColorBlock colors = button.colors;
        colors.normalColor = color;
        colors.highlightedColor = color;
        colors.pressedColor = color;
        colors.disabledColor = color;
        colors.selectedColor = color;
        button.colors = colors;
    }

    private void QuizEnd()
    {
        _questCanvas.enabled = false;
        _nextQuestion.gameObject.SetActive(false);

        QuizOver?.Invoke();
    }
}
