using DataAccessLibrary.Models;

namespace BlazorMediLab.Services
{
    public class SurveyService
    {
        public List<SkinSurveyQuestion> GetSkinSurveyQuestions()
        {
            return new List<SkinSurveyQuestion>
            {
                new SkinSurveyQuestion
                {
                    Id = 0,
                    Question = "How would you describe your skin?",
                    Options = new List<string> { "Normal", "Oily", "Combination", "Dry", "Sensitive", "Not Sure" },
                    SelectedAnswers = new List<string>()
                },
                new SkinSurveyQuestion
                {
                    Id = 1,
                    Question = "Select your top three skin concerns?",
                    Options = new List<string> { "Fine Lines", "Deep Lines", "Breakouts", "Dark Circles Under Eyes", "Uneven Tone", "Elasticity", "Sensitivity", "Blackheads", "Dehydration", "Body Acne" },
                    SelectedAnswers = new List<string>()
                },
                new SkinSurveyQuestion
                {
                    Id = 2,
                    Question = "Select all of the products you currently use?",
                    Options = new List<string> { "Pre-cleanser", "Cleanser","Exfoliant", "Toner", "Moisturizer", "Serum/Oil", "Masque", "Retinol", "Eye Cream", "SPF", "Lip Treatment" },
                    SelectedAnswers = new List<string>()
                },
                new SkinSurveyQuestion
                {
                    Id = 3,
                    Question = "Which of the following best describes your age?",
                    Options = new List<string> { "Under 18", "18-30", "31-45", "46-60", "Above 60" },
                    SelectedAnswers = new List<string>()
                }
            };
        }
    }
}
