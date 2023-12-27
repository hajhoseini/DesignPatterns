using _02_FactoryMethod.Interviewer;

namespace _02_FactoryMethod.Manager;

abstract class HiringManager
{
    abstract protected IInterviewer MakeInterviewer();

    public void TakeInterview()
    {
        var interviewer = MakeInterviewer();
        interviewer.AskQuestions();
    }
}
