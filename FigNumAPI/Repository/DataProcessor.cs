using FigNumAPI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FigNumAPI.Repository
{
    public class DataProcessor : IProcess
    {
        /// <summary>
        /// Method to trim prime numbers
        /// </summary>
        /// <param name="strList"></param>
        /// <returns></returns>
        public List<string> NonPrimeNumbers(string strList)
        {
            List<string> nonPrimeNumbers = new List<string>();
            if (string.IsNullOrEmpty(strList))
                return nonPrimeNumbers;
            string[] lstNumbers = strList.Split(',');

            for (int i = 0; i < lstNumbers.Length; i++)
            {
                //validate whether each character is number
                if (string.IsNullOrEmpty(lstNumbers[i]) || !lstNumbers[i].All(Char.IsDigit) || Convert.ToInt32(lstNumbers[i]) == 1)
                {
                    if (lstNumbers[i].All(Char.IsDigit) && Convert.ToInt32(lstNumbers[i]) == 1)
                        nonPrimeNumbers.Add(lstNumbers[i]);

                    continue;
                }
                //find whether divisible
                for (int j = 2; j <= Convert.ToInt32(lstNumbers[i]) / 2; j++)
                {
                    if (Convert.ToInt32(lstNumbers[i]) % j == 0)
                    {
                        nonPrimeNumbers.Add(lstNumbers[i]);
                        break;
                    }
                }
            }
            return nonPrimeNumbers;
        }
    }
}
