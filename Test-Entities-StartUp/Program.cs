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
            Context c = new Context();
            //CreateTicket();
            //CreateSurvey();
            //CreateSurvey();
          
           
            var range = c.Tickets.Where(x => x.TicketId == 3).Include(y => y.Survey);
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
           

            var ticket = c.Tickets.Find(3);
            Survey survey = new Survey { Message = "Test"};
            ticket.Survey = survey;

            var process = c.Processes.Where(x => x.ProcessId == 2).SingleOrDefault();

            ticket.Process = process;
            c.Update(ticket);


            Answer answer = new Answer() { AnswerDescription = "Çok İyi" };
            Answer answer2 = new Answer() { AnswerDescription = " İyi" };
           
            Question question = new Question() { QuestionDescription = "Testler iyi mi 2 ?" };
            Question question2 = new Question() { QuestionDescription = "Sonuçlar iyi mi 2 ?" };

            c.AddRange(answer, answer2,question,question2);
            c.SaveChangesAsync();

            List<Answer_Question> answer_Questions = new List<Answer_Question>() {
             new Answer_Question { Answer = answer, Question = question },
             new Answer_Question { Answer = answer2, Question = question2 },
           
            };
          
            survey.Answer_Question = answer_Questions;
            c.Surveys.Update(survey);
            c.SaveChangesAsync();

        }
    }
}
