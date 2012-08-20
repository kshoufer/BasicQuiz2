using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicQuiz_v2_
{
    class UserScore
    {
        public int intRowID { get; set; }
        public int intUserID { get; set; }
        public string strUserName { get; set; }
        public string strQuestionDescription { get; set; }
        public int intUserAnswerID { get; set; }
        public string strUserAnswerDescription { get; set; }
        public int intQuizCorrectQuestionID { get; set; }
        public string strQuizCorrectDescription { get; set; }
        public int intUserQuestionScore { get; set; }
    }
}
