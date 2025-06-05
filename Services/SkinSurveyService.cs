// using DataAccessLibrary.Models;

// namespace BlazorMediLab.Services
// {
//     public class SkinSurveyService
//     {
//         public List<SkinSurveyQuestion> Questions { get; private set; } = new();
//         public Dictionary<int, string> Responses { get; private set; } = new();

//         public int CurrentQuestionIndex { get; private set; } = 0;

//         public SkinSurveyService()
//         {
//             LoadQuestions();
//         }

//         private void LoadQuestions()
//         {
//             Questions = new List<SkinSurveyQuestion>
//             {
//                 new() { Id = 1, Question = "Do you have any red patches on your skin?", Options = new List<string> { "Yes", "No", "Not Sure" } },
//                 new() { Id = 2, Question = "Have you experienced any unusual skin itching?", Options = new List<string> { "Yes", "No", "Sometimes" } },
//                 new() { Id = 3, Question = "Do you notice any new moles or growths?", Options = new List<string> { "Yes", "No", "Not Sure" } },
//                 // Add the rest of your survey questions here
//             };
//         }

//         public SkinSurveyQuestion GetCurrentQuestion()
//         {
//             return Questions[CurrentQuestionIndex];
//         }

//         public void SaveResponse(string response)
//         {
//             int questionId = Questions[CurrentQuestionIndex].Id;
//             Responses[questionId] = response;
//         }

//         public void NextQuestion()
//         {
//             if (CurrentQuestionIndex < Questions.Count - 1)
//                 CurrentQuestionIndex++;
//         }

//         public void PreviousQuestion()
//         {
//             if (CurrentQuestionIndex > 0)
//                 CurrentQuestionIndex--;
//         }

//         public bool IsLastQuestion => CurrentQuestionIndex == Questions.Count - 1;
//         public bool IsFirstQuestion => CurrentQuestionIndex == 0;

//         public void ResetSurvey()
//         {
//             CurrentQuestionIndex = 0;
//             Responses.Clear();
//         }
//     }
// }
