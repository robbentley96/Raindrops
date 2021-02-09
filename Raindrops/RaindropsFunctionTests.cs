using NUnit.Framework;

namespace Raindrops
{
	public class RaindropsFunctionTests
	{
		[TestCase(3)]
		[TestCase(6)]
		[TestCase(-9)]
		public void MultiplesOfThreeReturnPling(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("Pling"));
		}

		[TestCase(5)]
		[TestCase(10)]
		[TestCase(-20)]
		public void MultiplesOfFiveReturnPlang(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("Plang"));
		}

		[TestCase(7)]
		[TestCase(14)]
		[TestCase(-28)]
		public void MultiplesOfSevenReturnPlong(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("Plong"));
		}

		[TestCase(15)]
		[TestCase(30)]
		[TestCase(-45)]
		public void MultiplesOfThreeAndFiveReturnPlingPlang(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("PlingPlang"));
		}

		[TestCase(21)]
		[TestCase(42)]
		[TestCase(-63)]
		public void MultiplesOfThreeAndSevenReturnPlingPlong(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("PlingPlong"));
		}

		[TestCase(35)]
		[TestCase(70)]
		[TestCase(-140)]
		public void MultiplesOfFiveAndSevenReturnPlangPlong(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("PlangPlong"));
		}

		[TestCase(105)]
		[TestCase(210)]
		[TestCase(-315)]
		public void MultiplesOfThreeFiveAndSevenReturnPlingPlangPlong(int num)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo("PlingPlangPlong"));
		}

		[TestCase(1,"1")]
		[TestCase(2,"2")]
		[TestCase(-71,"-71")]
		public void NonMultiplesOfThreeFiveSevenReturnIntegerValueAsString(int num,string expected)
		{
			string raindropsOutput = RaindropsLibrary.RaindropsMethod(num);
			Assert.That(raindropsOutput, Is.EqualTo(expected));
		}
	}
}