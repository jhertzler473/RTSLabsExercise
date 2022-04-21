using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSLabsExercise
{
    public static class InputChecker
    {
        public static Dictionary<string, int> AboveBelow(List<int> integerList, int comparison, bool inclusive = false)
        {
            return new Dictionary<string, int>
            {
                { "above", integerList.Count(val => inclusive ? val >= comparison : val > comparison) },
                { "below", integerList.Count(val => inclusive ? val <= comparison : val < comparison) }
            };
        }


        public static string StringRotation(string originalString, int rotationAmount)
        {
            // mod out the full rotations
            int baseRotation = rotationAmount % originalString.Length;

            // append the rotation
            return $"{originalString.Substring(originalString.Length - baseRotation, baseRotation)}{originalString.Substring(0, originalString.Length - baseRotation)}";
        }
    }
}
