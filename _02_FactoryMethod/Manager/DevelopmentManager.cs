using _02_FactoryMethod.Interviewer;

namespace _02_FactoryMethod.Manager;

class DevelopmentManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}
