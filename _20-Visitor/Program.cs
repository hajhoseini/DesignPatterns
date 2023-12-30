using _20_Visitor.Animal;

namespace _20_Visitor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var monkey = new Monkey();
			var lion = new Lion();
			var dolphin = new Dolphin();

			var speak = new Speak();

			monkey.Accept(speak);    // Ooh oo aa aa!
			lion.Accept(speak);      // Roaaar!
			dolphin.Accept(speak);   // Tuut tutt tuutt!

			var jump = new Jump();

			monkey.Accept(speak);   // Ooh oo aa aa!
			monkey.Accept(jump);    // Jumped 20 feet high! on to the tree!

			lion.Accept(speak);     // Roaaar!
			lion.Accept(jump);      // Jumped 7 feet! Back on the ground!

			dolphin.Accept(speak);  // Tuut tutt tuutt!
			dolphin.Accept(jump);   // Walked on water a little and disappeared
		}
	}
}