using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anketa.Tests
{
    [TestClass]
    public class AnketaTests
    {
        [TestMethod]
        public void Fio_1()
        {
            string fio = "Кузнецова Дарья";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.FIO(fio);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Fio_2()
        {
            string fio = "Кузнецова Дарья Александровна";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.FIO(fio);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Fio_3()
        {
            string fio = "кузнецова дарья";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.FIO(fio);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Fio_4()
        {
            string fio = "КузнецоваДарья";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.FIO(fio);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Fio_5()
        {
            string fio = "Кузнецова дарья";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.FIO(fio);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Data_1()
        {
            string data = "28.11.2000";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.Data(data);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Data_2()
        {
            string data = "28112000";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Data(data);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Data_3()
        {
            string data = "288.11.2000";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Data(data);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Data_4()
        {
            string data = "dd.cc.gggg";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Data(data);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Data_5()
        {
            string data = "28.11.-452";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Data(data);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Tel_1()
        {
            string tel = "89969584432";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.Tel(tel);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tel_2()
        {
            string tel = "+79969584432";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.Tel(tel);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tel_3()
        {
            string tel = "899695844";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Tel(tel);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tel_4()
        {
            string tel = "+789969584432";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Tel(tel);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tel_5()
        {
            string tel = "qwertyuiopa";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Tel(tel);

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Mail_1()
        {
            string mail = "darya@mail.ru";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.Mail(mail);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mail_2()
        {
            string mail = "dar.ya@mail.ru";
            string expected = "1";

            Anketa a = new Anketa();
            string actual = a.Mail(mail);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mail_3()
        {
            string mail = "daryamail.ru";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Mail(mail);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mail_4()
        {
            string mail = "darya@mailru";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Mail(mail);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mail_5()
        {
            string mail = "da@rya@mail.ru";
            string expected = "0";

            Anketa a = new Anketa();
            string actual = a.Mail(mail);

            Assert.AreEqual(expected, actual);
        }
    }
}
