using NUnit.Framework;

using DateFormat;

namespace Tests
{
    public class Tests
    {
        private string date;
        [SetUp]
        public void Setup()
        {
            date = "10/09/2003";
        }
        /*
        Test verificador del cambio del formato ISO correctamente
        */
        [Test]
        public void Test_CambiarFormatoISO() 
        {
            string Expected_Date = Program.ChangeFormatISO(date);
            date = "2003-09-10";
            Assert.AreEqual(date,Expected_Date);
        }
        /*
        Test verificador del cambio del formato europeo correctamente
        */
        [Test]
        public void Test_CambiarFormatoEuropeo() 
        {
            string Expected_Date = Program.ChangeFormatEuropeo(date);
            date = "10-09-2003";
            Assert.AreEqual(date,Expected_Date);
        }   
    }
}