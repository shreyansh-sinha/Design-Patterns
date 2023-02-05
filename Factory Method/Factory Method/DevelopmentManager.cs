namespace Factory_Method
{
    public class DevelopmentManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new Developer();
        }
    }
}
