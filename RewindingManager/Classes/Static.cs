using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RewindingManager.Classes
{
    internal class Static
    {
        public static void setMachineLeftFillColor(Components.UserControl1 machine, String color)
        {
            machine.TxtLeftLotNo.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftArticleNo.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftInst.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftSpec.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftDia.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftLength.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftDate.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtLeftTime.FillColor = ColorTranslator.FromHtml(color);
            machine.PanelLeft.BackColor = ColorTranslator.FromHtml(color);
        }
        public static void setMachineCenterFillColor(Components.UserControl1 machine, String color)
        {
            machine.TxtCenterLotNo.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterArticleNo.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterInst.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterSpec.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterDia.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterLength.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterDate.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtCenterTime.FillColor = ColorTranslator.FromHtml(color);
            machine.PanelCenter.BackColor = ColorTranslator.FromHtml(color);
        }
        public static void setMachineRightFillColor(Components.UserControl1 machine, String color)
        {
            machine.TxtRightLotNo.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightArticleNo.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightInst.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightSpec.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightDia.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightLength.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightDate.FillColor = ColorTranslator.FromHtml(color);
            machine.TxtRightTime.FillColor = ColorTranslator.FromHtml(color);
            machine.PanelRight.BackColor = ColorTranslator.FromHtml(color);
        }
        public static void clearMachineTextLeft(Components.UserControl1 machine)
        {
            machine.TxtLeftLotNo.Clear();
            machine.TxtLeftArticleNo.Clear();
            machine.TxtLeftInst.Clear();
            machine.TxtLeftSpec.Clear();
            machine.TxtLeftDia.Clear();
            machine.TxtLeftLength.Clear();
            machine.TxtLeftDate.Clear();
            machine.TxtLeftTime.Clear();
        }
        public static void clearMachineTextCenter(Components.UserControl1 machine)
        {
            machine.TxtCenterLotNo.Clear();
            machine.TxtCenterArticleNo.Clear();
            machine.TxtCenterInst.Clear();
            machine.TxtCenterSpec.Clear();
            machine.TxtCenterDia.Clear();
            machine.TxtCenterLength.Clear();
            machine.TxtCenterDate.Clear();
            machine.TxtCenterTime.Clear();
        }
        public static void clearMachineTextRight(Components.UserControl1 machine)
        {
            machine.TxtRightLotNo.Clear();
            machine.TxtRightArticleNo.Clear();
            machine.TxtRightInst.Clear();
            machine.TxtRightSpec.Clear();
            machine.TxtRightDia.Clear();
            machine.TxtRightLength.Clear();
            machine.TxtRightDate.Clear();
            machine.TxtRightTime.Clear();
        }

        public static String toCapitalFWEL(String text)
        {
            string[] words = text.Split(' ');
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            for(int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = textInfo.ToTitleCase(words[i]);
                }
            }

            string capitalizedString = string.Join(" ", words);
            return capitalizedString;
        }
    }
}
