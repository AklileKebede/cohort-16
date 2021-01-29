using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DataFashion_Test
    {/*(me,date,tableChances) 
      * me/date: int range 0..10
      * table: int 0=no, 1=maybe, 2=yes
      * very stylish: 8 or more => result is 2
      * style: 2 or less, =>  result is 0 
      * dateFashion(5, 10) → 2
        dateFashion(5, 2) → 0
        dateFashion(5, 5) → 1
     */
        [DataTestMethod]
        [DataRow(5, 10,2)]
        [DataRow(5, 2,0)] 
        [DataRow(5, 5,1)] 
        [DataRow(8,1,0)] 
        
        public void TableChances_Test(int me, int date, int expectedTableChance)
        {
            //Arrange
            DateFashion tableTest = new DateFashion();

            //Assert
            Assert.AreEqual(expectedTableChance, tableTest.GetATable(me, date)); //Actually Assert +Invoke
        }
    }
}
