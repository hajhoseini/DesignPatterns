namespace _17_Mediator;

class User
{
    private string _name;
    private IChatRoomMediator _chatRoom;

	public User(string name, IChatRoomMediator chatRoom)
    {
        _name = name;
        _chatRoom = chatRoom;
    }

    public string GetName()
    {
        return _name;
    }

    public void Send(string message)
    {
        _chatRoom.ShowMessage(this, message);
    }
}