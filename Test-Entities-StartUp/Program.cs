using System;
using Test_Entities.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Test_Entities_StartUp
{
    public class Program
    {
       
        public static void Main(string[] args)
        {

            CreateTicket();
            CreateSurvey();
            //CreateSurvey();
            Context c = new Context();
            var foundedTicket =  c.Tickets.Find(1);
            var range = c.Tickets.Where(x => x.TicketId == 5).Include(y => y.Survey);

            c.RemoveRange(range);
            c.SaveChangesAsync();




        }

        public static void CreateTicket()
        {
            Context c = new Context();
            Ticket ticket = new Ticket { TicketCode = "FEY-1" };

            c.Tickets.Add(ticket);
            c.SaveChangesAsync();
        }

        public static void CreateSurvey()
        {
            Context c = new Context();
           

            var ticket = c.Tickets.Find(5);
            Survey survey = new Survey { Message = "Test"};
            ticket.Survey = survey;
           
            c.Update(ticket);

            Answer answer = new Answer() { AnswerDescription = "Çok İyi" };
            Answer answer2 = new Answer() { AnswerDescription = " İyi" };
           
            Question question = new Question() { QuestionDescription = "Testler iyi mi ?" };
            Question question2 = new Question() { QuestionDescription = "Sonuçlar iyi mi ?" };

            c.AddRange(answer, answer2,question,question2);
            c.SaveChangesAsync();

            List<Answer_Question> answer_Questions = new List<Answer_Question>() {
             new Answer_Question { Answer = answer, Question = question }
            };

            survey.Answer_Question = answer_Questions;
            c.Surveys.Update(survey);
            c.SaveChangesAsync();

        }
    }
}
