using System.Drawing;
using System.Text;

namespace _04_Builder;

class Burger
{
	private int mSize;
	private bool mCheese;
	private bool mPepperoni;
	private bool mLettuce;
	private bool mTomato;

    /*public Burger(int size, bool cheese, bool pepperoni, bool lettuce, bool tomato)
	{
		mSize = size;
		mCheese = cheese;
		mPepperoni = pepperoni;
		mLettuce = lettuce;
		mTomato = tomato;
    }*/

    public Burger(BurgerBuilder burgerBuilder)
    {
		mSize = burgerBuilder.Size;
		mCheese = burgerBuilder.Cheese;
		mPepperoni = burgerBuilder.Pepperoni;
		mLettuce = burgerBuilder.Lettuce;
		mTomato = burgerBuilder.Tomato;
	}

    public string GetDescription()
	{
		var sb = new StringBuilder();
		sb.Append($"This is {this.mSize} inch Burger. ");
		return sb.ToString();
	}
}
