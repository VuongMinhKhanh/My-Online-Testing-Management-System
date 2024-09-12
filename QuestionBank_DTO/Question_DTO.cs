using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    public class Question_DTO
    {
        private int idQuestion;
        private string question;
        private List<String> answers;
        private List<int> idAnswers;
        private int idCorrectAnswer;
        private int correctAnswer;
        private bool status;
        private string idSubject;

        // getter setter
        public int IdQuestion { get { return idQuestion; } set { idQuestion = value; } }
        public string Question { get { return question; } set { question = value; } }
        public List<String> Answers { get { return answers; } set { answers = value; } }
        public List<int> IdAnswers { get { return idAnswers; } set { idAnswers = value; } }
        public int IdCorrectAnswer { get { return idCorrectAnswer; } set { idCorrectAnswer = value; } }
        public int CorrectAnswer { get { return correctAnswer; } set { correctAnswer = value; } }
        public bool Status { get { return status; } set { status = value; } }

        public string IdSubject { get { return idSubject; } set { idSubject = value; } }
        public Question_DTO() { }
        public Question_DTO(string question, List<String> answers,
            int correctAnswer, bool status, string idSubject)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.status = status;
            this.idSubject = idSubject;
        }

        public Question_DTO(int idQuestion, string question,
            List<int> idAnswers, List<String> answers,
            int idCorrectAnswer, int correctAnswer,
            bool status, string idSubject)
        {
            this.idQuestion = idQuestion;
            this.question = question;
            this.idAnswers = idAnswers;
            this.answers = answers;
            this.idCorrectAnswer = idCorrectAnswer;
            this.correctAnswer = correctAnswer;
            this.status = status;
            this.idSubject = idSubject;
        }

        public Question_DTO(int idQuestion,
            List<int> idAnswers,
            int idCorrectAnswer)
        {
            this.idQuestion = idQuestion;
            this.idAnswers = idAnswers;
            this.idCorrectAnswer = idCorrectAnswer;
        }
    }
}
