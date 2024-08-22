using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows;
using System.Collections.ObjectModel;

namespace TimotheusUS.MVVMsamples.BindableRichTextBox
{
    public class Model1
    {
        public List<Paragraph> GetESNG1000WDocumentation()
        {
            var block1 = new Paragraph(new Run("Power Supply ESNG 1000W ")) { FontSize = 18, FontStyle = FontStyles.Italic };
            var block2 = new Paragraph(new Run("Volleinschub 19\"2HE, Anschlüsse vorne und hinten\r"));
            var inlines21 = new Run("dynamische Spannungsregelung(U)");
            block2.Inlines.Add(inlines21);
            return new List<Paragraph>() { block1, block2 };
        }

        public List<Paragraph> GetHFE1600Documentation()
        {
            var block1 = new Paragraph(new Run("HFE1600 ")) { FontSize = 18, FontStyle = FontStyles.Italic };
            var block2 = new Paragraph(new Run("Die Netzteilreihe HFE hat es in sich: Die 1 HE hohen "));
            var inlines21 = new Run("Frontend-Netzteile ") { FontWeight = FontWeights.Bold };
            var inlines22 = new Run("mit 1,6 kW bzw. 2,5 kW Einzelausgang haben eine");
            block2.Inlines.Add(inlines21);
            block2.Inlines.Add(inlines22);
            return new List<Paragraph>() { block1, block2 };
        }
    }
}