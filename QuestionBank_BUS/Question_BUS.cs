using QuestionBank_DAO;
using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuestionBank_BUS
{
    public class Question_BUS
    {
        Question_DAO question = new Question_DAO();
        public DataTable getQuestions(string id_subject)
        {
            return question.getQuestions(id_subject);
        }

        public bool addQuestion(Question_DTO question)
        {
            return this.question.addQuestion(question);
        }

        public DataTable getAnswers(int id) 
        {
            return question.getAnswers(id);
        }

        public bool adjustQuestion(Question_DTO question)
        {
            return this.question.adjustQuestion(question);
        }

        public bool deleteQuestion(Question_DTO question)
        {
            return this.question.deleteQuestion(question);
        }

        public DataTable getRandomQuestions(int questionNumber,
            string idSubject)
        {
            return question.getRandomQuestions(questionNumber, idSubject);
        } 
    }
}
