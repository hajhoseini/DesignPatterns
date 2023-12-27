namespace _06_Singleton;

public class President
{
    public static President instance;

    private President()
    {
            
    }

    public static President GetInstance()
    {
        if(instance == null)
            instance = new President();

        return instance;
    }
}
