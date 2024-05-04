using NUnit.Framework;
using System.Text.RegularExpressions;

[TestFixture]
public class TypographRulesTests
{
    private void TypographRules(ref string text)
    {
        //Правило 19
        text = text.Replace("&", "&");

        //Правило 17
        text = Regex.Replace(text, @"\bампер-вольт\b", "А · В", RegexOptions.IgnoreCase);

        //Правило 13
        text = text.Replace("...", "…");

        //Правило 9
        text = text.Replace("+-", "±");

        //Правило 5
        text = Regex.Replace(text, @"\s*-\s*", "-");

        //Правило ё заменяется на йо
        text = text.Replace("ё", "йо");

        //Правило после цифры и перед знаком % должен стоять пробел
        text = Regex.Replace(text, @"(?<!\s)(%)", " $1");
    }

    [Test]
    public void Test1()
    {
        string input = "a & b";
        string output = "a & b";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test2()
    {
        string input = "Ампер-вольт это единица измерения";
        string output = "А · В это единица измерения";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test3()
    {
        string input = "Это... многоточие";
        string output = "Это… многоточие";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test4()
    {
        string input = "Результат +-5";
        string output = "Результат ±5";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test5()
    {
        string input = "5 - 3";
        string output = "5-3";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test6()
    {
        string input = "Ёжик";
        string output = "Йожик";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test7()
    {
        string input = "100%";
        string output = "100 %";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test8()
    {
        string input = "...Ампер-вольт 5-3 100%";
        string output = "…А · В 5-3 100 %";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test9()
    {
        string input = "Строка без изменений";
        string output = "Строка без изменений";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test10()
    {
        string input = "";
        string output = "";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }
}
