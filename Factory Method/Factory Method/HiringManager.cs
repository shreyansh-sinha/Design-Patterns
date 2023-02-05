namespace Factory_Method
{
    public abstract class HiringManager
    {
        private IInterviewer? Interviewer { get; set; }
        public abstract IInterviewer makeInterviewer();
        public void takeInterview()
        {
            Interviewer = makeInterviewer();
            Interviewer.askQuestions();
        }
    }
}
