using NUnit.Framework;
using System.Text.RegularExpressions;

[TestFixture]
public class TypographRulesTests
{
    private void TypographRules(ref string text)
    {
        //������� 19
        text = text.Replace("&", "&");

        //������� 17
        text = Regex.Replace(text, @"\b�����-�����\b", "� � �", RegexOptions.IgnoreCase);

        //������� 13
        text = text.Replace("...", "�");

        //������� 9
        text = text.Replace("+-", "�");

        //������� 5
        text = Regex.Replace(text, @"\s*-\s*", "-");

        //������� � ���������� �� ��
        text = text.Replace("�", "��");

        //������� ����� ����� � ����� ������ % ������ ������ ������
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
        string input = "�����-����� ��� ������� ���������";
        string output = "� � � ��� ������� ���������";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test3()
    {
        string input = "���... ����������";
        string output = "��� ����������";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test4()
    {
        string input = "��������� +-5";
        string output = "��������� �5";
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
        string input = "����";
        string output = "�����";
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
        string input = "...�����-����� 5-3 100%";
        string output = "�� � � 5-3 100 %";
        TypographRules(ref input);
        Assert.AreEqual(output, input);
    }

    [Test]
    public void Test9()
    {
        string input = "������ ��� ���������";
        string output = "������ ��� ���������";
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
