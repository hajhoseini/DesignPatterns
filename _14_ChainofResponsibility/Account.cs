namespace _14_ChainofResponsibility;

abstract class Account
{
	private Account _successor;
	protected decimal _balance;

	public void SetNext(Account successor)
	{
		_successor = successor;
	}

	public void Pay(decimal amountTopay)
	{
		if(CanPay(amountTopay))
		{
			Console.WriteLine($"Paid {amountTopay:c} using {this.GetType().Name}.");
		}
		else if(this._successor != null)
		{
			Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding..");
			_successor.Pay(amountTopay);
		}
		else
		{
			throw new Exception("None of the accounts have enough balance");
		}
	}

	private bool CanPay(decimal amount)
	{
		return _balance >= amount;
	}
}
