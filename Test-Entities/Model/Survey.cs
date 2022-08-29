using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Survey
    {
        [Key]
        public int SurveyId { get; set; }
        public string Message { get; set; }

        virtual public List<Answer_Question> Answer_Question { get; set; }
    }
}
