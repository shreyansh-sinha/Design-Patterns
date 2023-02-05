using Factory_Method;

public class Program
{
    public static void Main(String[] args)
    {
        var interviewer = Factory.GetInterviewer("Development");
        interviewer.takeInterview();

        interviewer = Factory.GetInterviewer("Executive");
        interviewer.takeInterview();
        
    }
}