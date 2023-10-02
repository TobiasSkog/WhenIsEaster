using NUnit.Framework;
using WhenIsEaster.App.Logic.GaussFormula;

namespace WhenIsEaster.Tests
{
  [TestFixture]
  public class WhenIsEasterTests
  {
    [Test]
    public void Get_M_FromTable_Success()
    {
      int expectedYear1 = 1699;
      int M1 = 22;
      int expectedYear2 = 1799;
      int M2 = 23;
      int expectedYear3 = 1899;
      int M3 = 23;
      int expectedYear4 = 1999;
      int M4 = 24;
      int expectedYear5 = 2099;
      int M5 = 24;
      int expectedYear6 = 2199;
      int M6 = 24;
      int expectedYear7 = 2299;
      int M7 = 25;
      int expectedYear8 = 2399;
      int M8 = 26;
      int expectedYear9 = 2499;
      int M9 = 25;
      int expectedYear10 = 2599;
      int M10 = 26;

      var actualValue1 = MetonsCykel.GetMetonsCykel(expectedYear1);
      var actualValue2 = MetonsCykel.GetMetonsCykel(expectedYear2);
      var actualValue3 = MetonsCykel.GetMetonsCykel(expectedYear3);
      var actualValue4 = MetonsCykel.GetMetonsCykel(expectedYear4);
      var actualValue5 = MetonsCykel.GetMetonsCykel(expectedYear5);
      var actualValue6 = MetonsCykel.GetMetonsCykel(expectedYear6);
      var actualValue7 = MetonsCykel.GetMetonsCykel(expectedYear7);
      var actualValue8 = MetonsCykel.GetMetonsCykel(expectedYear8);
      var actualValue9 = MetonsCykel.GetMetonsCykel(expectedYear9);
      var actualValue10 = MetonsCykel.GetMetonsCykel(expectedYear10);


      Assert.AreEqual(M1, actualValue1.Item1);
      Assert.AreEqual(M2, actualValue2.Item1);
      Assert.AreEqual(M3, actualValue3.Item1);
      Assert.AreEqual(M4, actualValue4.Item1);
      Assert.AreEqual(M5, actualValue5.Item1);
      Assert.AreEqual(M6, actualValue6.Item1);
      Assert.AreEqual(M7, actualValue7.Item1);
      Assert.AreEqual(M8, actualValue8.Item1);
      Assert.AreEqual(M9, actualValue9.Item1);
      Assert.AreEqual(M10, actualValue10.Item1);
    }
    [Test]
    public void Get_N_FromTable_Success()
    {
      int expectedYear1 = 1583;
      int N1 = 2;
      int expectedYear2 = 1700;
      int N2 = 3;
      int expectedYear3 = 1800;
      int N3 = 4;
      int expectedYear4 = 1900;
      int N4 = 5;
      int expectedYear5 = 2000;
      int N5 = 5;
      int expectedYear6 = 2100;
      int N6 = 6;
      int expectedYear7 = 2200;
      int N7 = 0;
      int expectedYear8 = 2300;
      int N8 = 1;
      int expectedYear9 = 2400;
      int N9 = 1;
      int expectedYear10 = 2500;
      int N10 = 2;

      var actualValue1 = MetonsCykel.GetMetonsCykel(expectedYear1);
      var actualValue2 = MetonsCykel.GetMetonsCykel(expectedYear2);
      var actualValue3 = MetonsCykel.GetMetonsCykel(expectedYear3);
      var actualValue4 = MetonsCykel.GetMetonsCykel(expectedYear4);
      var actualValue5 = MetonsCykel.GetMetonsCykel(expectedYear5);
      var actualValue6 = MetonsCykel.GetMetonsCykel(expectedYear6);
      var actualValue7 = MetonsCykel.GetMetonsCykel(expectedYear7);
      var actualValue8 = MetonsCykel.GetMetonsCykel(expectedYear8);
      var actualValue9 = MetonsCykel.GetMetonsCykel(expectedYear9);
      var actualValue10 = MetonsCykel.GetMetonsCykel(expectedYear10);


      Assert.AreEqual(N1, actualValue1.Item2);
      Assert.AreEqual(N2, actualValue2.Item2);
      Assert.AreEqual(N3, actualValue3.Item2);
      Assert.AreEqual(N4, actualValue4.Item2);
      Assert.AreEqual(N5, actualValue5.Item2);
      Assert.AreEqual(N6, actualValue6.Item2);
      Assert.AreEqual(N7, actualValue7.Item2);
      Assert.AreEqual(N8, actualValue8.Item2);
      Assert.AreEqual(N9, actualValue9.Item2);
      Assert.AreEqual(N10, actualValue10.Item2);


    }
    [Test]
    public void GetTuple_MN_FromTable_Success()
    {
      int expectedYear1 = 1699;
      var M1N1 = new Tuple<int, int>(22, 2);
      int expectedYear2 = 1799;
      var M2N2 = new Tuple<int, int>(23, 3);
      int expectedYear3 = 1899;
      var M3N3 = new Tuple<int, int>(23, 4);
      int expectedYear4 = 1999;
      var M4N4 = new Tuple<int, int>(24, 5);
      int expectedYear5 = 2099;
      var M5N5 = new Tuple<int, int>(24, 5);
      int expectedYear6 = 2199;
      var M6N6 = new Tuple<int, int>(24, 6);
      int expectedYear7 = 2299;
      var M7N7 = new Tuple<int, int>(25, 0);
      int expectedYear8 = 2399;
      var M8N8 = new Tuple<int, int>(26, 1);
      int expectedYear9 = 2499;
      var M9N9 = new Tuple<int, int>(25, 1);
      int expectedYear10 = 2599;
      var M10N10 = new Tuple<int, int>(26, 2);


      var actualValue1 = MetonsCykel.GetMetonsCykel(expectedYear1);
      var actualValue2 = MetonsCykel.GetMetonsCykel(expectedYear2);
      var actualValue3 = MetonsCykel.GetMetonsCykel(expectedYear3);
      var actualValue4 = MetonsCykel.GetMetonsCykel(expectedYear4);
      var actualValue5 = MetonsCykel.GetMetonsCykel(expectedYear5);
      var actualValue6 = MetonsCykel.GetMetonsCykel(expectedYear6);
      var actualValue7 = MetonsCykel.GetMetonsCykel(expectedYear7);
      var actualValue8 = MetonsCykel.GetMetonsCykel(expectedYear8);
      var actualValue9 = MetonsCykel.GetMetonsCykel(expectedYear9);
      var actualValue10 = MetonsCykel.GetMetonsCykel(expectedYear10);


      Assert.AreEqual(M1N1, actualValue1);
      Assert.AreEqual(M2N2, actualValue2);
      Assert.AreEqual(M3N3, actualValue3);
      Assert.AreEqual(M4N4, actualValue4);
      Assert.AreEqual(M5N5, actualValue5);
      Assert.AreEqual(M6N6, actualValue6);
      Assert.AreEqual(M7N7, actualValue7);
      Assert.AreEqual(M8N8, actualValue8);
      Assert.AreEqual(M9N9, actualValue9);
      Assert.AreEqual(M10N10, actualValue10);
    }


    [Test]
    public void GetEaster2001_Success()
    {
      var actualEasterYear = new GuassClass(2001);

      int expectedA = 6;
      int expectedB = 1;
      int expectedC = 6;
      int expectedD = 18;
      int expectedE = 6;
      int expectedM = 24;
      int expectedN = 5;
      DateTime expectedValue = new(2001, 05, 15);

      Assert.AreEqual(expectedA, actualEasterYear.a);
      Assert.AreEqual(expectedB, actualEasterYear.b);
      Assert.AreEqual(expectedC, actualEasterYear.c);
      Assert.AreEqual(expectedD, actualEasterYear.d);
      Assert.AreEqual(expectedE, actualEasterYear.e);
      Assert.AreEqual(expectedM, actualEasterYear.M);
      Assert.AreEqual(expectedN, actualEasterYear.N);
      Assert.AreEqual(expectedValue, actualEasterYear.EasterDate);
    }

    [Test]
    public void GetExceptionDate_2035_Success()
    {
      var actualEasterYear = new GuassClass(2035);

      int expectedA = 2;
      int expectedB = 35;
      int expectedC = 40;
      int expectedD = 2;
      int expectedE = 2;
      int expectedM = 24;
      int expectedN = 5;
      DateTime expectedValue = new(2035, 04, 19);

      Assert.AreEqual(expectedA, actualEasterYear.a);
      Assert.AreEqual(expectedB, actualEasterYear.b);
      Assert.AreEqual(expectedC, actualEasterYear.c);
      Assert.AreEqual(expectedD, actualEasterYear.d);
      Assert.AreEqual(expectedE, actualEasterYear.e);
      Assert.AreEqual(expectedM, actualEasterYear.M);
      Assert.AreEqual(expectedN, actualEasterYear.N);
      Assert.AreEqual(expectedValue, actualEasterYear.EasterDate);
    }

  }
}