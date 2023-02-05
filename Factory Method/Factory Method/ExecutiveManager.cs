namespace Factory_Method
{
    public class ExecutiveManager : HiringManager
    {
        public override IInterviewer makeInterviewer()
        {
            return new Executive();
        }
    }
}
