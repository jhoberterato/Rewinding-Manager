using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewindingManager.Classes
{
    internal class Theme: MainClass
    {
        public String theme;
        public String background2;
        public String cancelFill;
        public String cancelFore;
        public String disabledBtnFill;
        public String disabledBtnBorder;
        public String disabledBtnFore;

        public String background1;
        public String borderColor;
        public String foreColor;
        public String disabled;
        public String unSelectedButtonLine;

        public Theme()
        {
            this.cancelFill = "#FFBFBF";
            this.cancelFore = "#808080";
            this.background2 = "#EEEEEE";
            this.disabledBtnFill = "#CED4DA";
            this.disabledBtnFore = "#ADB5Bd";
            this.disabledBtnBorder = "#ADB5Bd";

            this.background1 = "#FCFCFC";
            this.borderColor = "#5E94FF";
            this.foreColor = "#636363";
            this.disabled = "#F2F0F0";
            this.unSelectedButtonLine = "#DEE9FF";
        }

        public void disableButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.Enabled = false;
            btn.DisabledState.FillColor = ColorTranslator.FromHtml(this.disabledBtnFill);
            btn.DisabledState.CustomBorderColor = ColorTranslator.FromHtml(this.disabledBtnBorder);
            btn.DisabledState.ForeColor = ColorTranslator.FromHtml(this.disabledBtnFore);
        }

        public string getBackground1(string  theme)
        {
            if(theme == "light")
            {
                this.background1 = "#FCFCFC";
            }
            else
            {
                this.background1 = "#141B2D";
            }

            return this.background1;
        }

        public string getBorderColor(string theme)
        {
            if(theme == "light")
            {
                this.borderColor = "#5E94FF";
            }
            else
            {
                this.borderColor = "#3E4396";
            }

            return this.borderColor;
        }
        
        public string getForeColor(string theme)
        {
            if(theme == "light")
            {
                this.foreColor = "#636363";
            }
            else
            {
                this.foreColor = "#E0E0E0";
            }

            return this.foreColor;
        }

        public string getDisabled(string theme)
        {
            if(theme == "light")
            {
                this.disabled = "#F2F0F0";
            }
            else
            {
                this.disabled = "#1F2A40";
            }

            return this.disabled;
        }

        public string getUnselectedButtonLine(string theme)
        {
            if (theme == "light")
            {
                this.unSelectedButtonLine = "#DEE9FF";
            }
            else
            {
                this.unSelectedButtonLine = "#EBECF4";
            }

            return this.unSelectedButtonLine;
        }
    }
}
