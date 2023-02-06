using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Client.Helpers
{
    internal class UCHelper
    {
        public static bool EmptyFieldValidation(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        internal static bool AllNumberValidation(TextBox txt)
        {
            if (EmptyFieldValidation(txt))
            {
                if (txt.Text.Any(s => char.IsLetter(s)))
                {
                    txt.BackColor = Color.LightCoral;
                    return false;
                }
                else
                {
                    txt.BackColor = Color.White;
                    return true;
                }
            }
            return false;
        }

        internal static bool JMBGValidation(TextBox txt)
        {
            try
            {
                if (txt.Text.Length != 13)
                {
                    txt.BackColor = Color.LightCoral;
                    return false;
                }
                else
                {
                    txt.BackColor = Color.White;
                    return true;
                }
                AllNumberValidation(txt);   
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool DataValidation(TextBox txt)
        {
            if (!DateTime.TryParseExact(txt.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                txt.BackColor = Color.LightCoral;
                txt.Text = "yyyy-MM-dd";
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }

        internal static void ResetFields(params TextBox[] txt)
        {
            foreach (TextBox t in txt)
                t.Text = "";
        }

        internal static bool EmailValidation(TextBox txt)
        {
            if( new EmailAddressAttribute().IsValid(txt.Text))
            {
                txt.BackColor = Color.White;
                return true;
            }
            else
            {
                txt.BackColor = Color.LightCoral;
                return false;
            }
        }
    }
}
