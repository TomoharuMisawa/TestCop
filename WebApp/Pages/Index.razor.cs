using Microsoft.AspNetCore.Components;

namespace WebApp.Pages
{
    public partial class Index : ComponentBase
    {
        private string Value1 { get; set; }
        private string Value2 { get; set; }
        private string Result { get; set; }

        private void PerformAddition()
        {
            if (IsValidInput(Value1, Value2, out double val1, out double val2))
            {
                Result = (val1 + val2).ToString();
            }
            else
            {
                Result = "🙅";
            }
        }

        private void PerformSubtraction()
        {
            if (IsValidInput(Value1, Value2, out double val1, out double val2))
            {
                Result = (val1 - val2).ToString();
            }
            else
            {
                Result = "🙅";
            }
        }

        private void PerformMultiplication()
        {
            if (IsValidInput(Value1, Value2, out double val1, out double val2))
            {
                Result = (val1 * val2).ToString();
            }
            else
            {
                Result = "🙅";
            }
        }

        private void PerformDivision()
        {
            if (IsValidInput(Value1, Value2, out double val1, out double val2))
            {
                if (val2 != 0)
                {
                    Result = (val1 / val2).ToString();
                }
                else
                {
                    Result = "🙅";
                }
            }
            else
            {
                Result = "🙅";
            }
        }

        private bool IsValidInput(string value1, string value2, out double val1, out double val2)
        {
            return double.TryParse(value1, out val1) && double.TryParse(value2, out val2);
        }
    }
}
