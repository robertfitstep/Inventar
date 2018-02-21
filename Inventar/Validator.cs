using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar
{
    static class Validator
    {
        public static bool ValidujVstup(string pCost, string pCount, string pWeight, string pName, int ItemTypeIndex, out int resultpCost, out int resultpCount, out double resultpWeight, out string resultMessage)
        {
            resultpCost = 0;
            resultpCount = 0;
            resultpWeight = 0;
            resultMessage = "Úspešne validované.";

            if (int.TryParse(pCost, out int resultCost) != true)
            {
                resultMessage = "Zadali ste nesprávny formát ceny.";
                return false;
            }
            if ((int.TryParse(pCount, out int resultCount) && resultCount > 0) != true)
            {
                resultMessage = "Zadali ste nesprávny počet vecí.";
                return false;
            }
            if (double.TryParse(pWeight, out double resultWeight) != true)
            {
                resultMessage = "Zadali ste nesprávnu váhu.";
                return false;
            }
            if (pName.Length > 20)
            {
                resultMessage = "Maximálny počet znakov v názve je 20.";
                return false;
            }
            if (ItemTypeIndex == -1)
            {
                resultMessage = "Zvoľte typ veci.";
                return false;
            }
            resultpCost = resultCost;
            resultpCount = resultCount;
            resultpWeight = resultWeight;
            return true;
        }


    }
}
