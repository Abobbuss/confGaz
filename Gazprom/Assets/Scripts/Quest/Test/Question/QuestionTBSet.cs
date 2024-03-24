using UnityEngine;

[CreateAssetMenu(fileName = "New Question Set", menuName = "Quiz/Question Set")]
public class QuestionTBSet : ScriptableObject
{
    public Question[] questions;
}