using _02_FactoryMethod.Interviewer;

namespace _02_FactoryMethod.Manager;

class MarketingManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}
