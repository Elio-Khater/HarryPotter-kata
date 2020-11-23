
using System;
using System.Collections.Generic;
using ttd_kata;
using Xunit;

namespace test
{
    public class Test
    {

        [Fact]
        public void NoBook_GetPrice_ShouldReturn0()
        {
            //arrange
            Program prog = new Program();
            //act
            double expected = 0;
            double actual = prog.GetPrice(new List<int>());
            //assert
            Assert.Equal(expected, actual);
            //Check.That<double>(actual).IsZero();

        }

        [Fact]
        public void OneBook_GetPrice_ShouldReturn8()
        {

            //arrange
            Program prog = new Program();
            List<int> books = new List<int> { 1 };
            
            //act
            double expected = 8;
            double actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);
            //Check.That<double>(actual).IsEqualTo(expected);
        }

        [Fact]
        public void SameBooks_GetPrice_ShouldReturn_8timesbooks()
        {
            //arrange
            Program prog = new Program();
            List<int> books = new List<int> { 1, 1, 1 };
            //act
            double expected = 8*books.Count;
            double actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TwoDifferentBooks_GetPrice_ShouldReturn_BookPriceWith5PercentDiscount()
        {

            //arrange
            Program prog = new Program();
            List<int> books = new List<int> { 1, 2 };
            

            //act
            double expected = 16*0.95;
            double actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void MultipleDifferentBooks_GetPrice_ShouldReturn_BookPriceWithAppropiateDiscount()
        {

            //arrange
            Program prog = new Program();
            List<int> books = new List<int> { 1, 2, 3 };


            //act
            double expected = 24 * 0.90;
            double actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);


            //act
            books.Add(4);
            expected = 32 * 0.80;
            actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);

            //act
            books.Add(5);
            expected = 40 * 0.75;
            actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void MixedBooks_GetPrice_ShouldReturn_CorrectBookPrice()
        {

            //arrange
            Program prog = new Program();
            List<int> books = new List<int> { 1, 2, 2 };


            //act
            double expected = 16 * 0.95 + 8;         
            double actual = prog.GetPrice(books);
            //assert
            Assert.Equal(expected, actual);

        }
    }
}
