using System.Linq;
namespace TimotheusUS.MVVMsamples.MessageBox
{
    public class Model1
    {
        public string ConvertText(string inputText) => inputText.ToUpper();

        public bool IsTextInUpperCaseLetters(string inputText) => inputText.ToUpper().Equals(inputText);
    }
}
