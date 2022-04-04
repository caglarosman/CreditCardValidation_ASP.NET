using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreditCardValidation
{
    public partial class CreditCardValidation : System.Web.UI.Page
    {
        enum CardType { NONE, VISA, VISA_ELECTRON, MASTERCARD, MAESTRO, DISCOVER };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (IsPaymentOK())
                PaymentResult.Style.Add(HtmlTextWriterStyle.Visibility, "visible");
        }

        private bool CheckValidity()
        {
            throw new NotImplementedException();
        }

        private bool IsPaymentOK()
        {
            if (!IsCreditCardNumberOKForLuhn())
                return false;
            else if (FindCardType(TextBoxCardNumber.Text) == CardType.NONE)
                return false;
            else
                return true;
        }

        private bool IsCreditCardNumberOKForLuhn()
        {
            int sum = 0;
            bool doubleDigit = false;

            for (int i = TextBoxCardNumber.Text.Length - 1; i >= 0; i--)
            {
                if (doubleDigit)
                {
                    if ((int.Parse(TextBoxCardNumber.Text[i].ToString()) * 2) >= 10)
                    {
                        sum += (int.Parse(TextBoxCardNumber.Text[i].ToString()) * 2) % 10 + 1;
                    }
                    else
                    {
                        sum += int.Parse(TextBoxCardNumber.Text[i].ToString()) * 2;
                    }
                }
                else
                {
                    sum += int.Parse(TextBoxCardNumber.Text[i].ToString());
                }
                doubleDigit = !doubleDigit;

            }

            if (sum % 10 == 0)
                return true;
            else
                return false;



        }

        private CardType FindCardType(string cardNumber)
        {
            try
            {
                if (cardNumber.Substring(0, 4) == "4026" || cardNumber.Substring(0, 6) == "417500" ||
                         cardNumber.Substring(0, 4) == "4405" || cardNumber.Substring(0, 4) == "4508" ||
                        cardNumber.Substring(0, 4) == "4844" || cardNumber.Substring(0, 4) == "4913" ||
                        cardNumber.Substring(0, 4) == "4917")
                {
                    return CardType.VISA_ELECTRON;
                }
                else if (cardNumber.Substring(0, 1) == "4")
                {
                    return CardType.VISA;
                }
                else if ((((int.Parse(cardNumber.Substring(0, 2))) >= 51 && (int.Parse(cardNumber.Substring(0, 2))) <= 55)) ||
                    (((int.Parse(cardNumber.Substring(0, 6))) >= 222100 && (int.Parse(cardNumber.Substring(0, 6))) <= 272099)))
                {
                    return CardType.MASTERCARD;
                }
                else if ((((int.Parse(cardNumber.Substring(0, 6))) >= 500000 && (int.Parse(cardNumber.Substring(0, 6))) <= 509999)) ||
                    (((int.Parse(cardNumber.Substring(0, 6))) >= 560000 && (int.Parse(cardNumber.Substring(0, 6))) <= 589999)) ||
                    (((int.Parse(cardNumber.Substring(0, 6))) >= 600000 && (int.Parse(cardNumber.Substring(0, 6))) <= 699999)))
                {
                    return CardType.MAESTRO;
                }
                else if (cardNumber.Substring(0, 4) == "6011" ||
                    (((int.Parse(cardNumber.Substring(0, 6))) >= 622126 && (int.Parse(cardNumber.Substring(0, 6))) <= 622925)) ||
                    (((int.Parse(cardNumber.Substring(0, 3))) >= 644 && (int.Parse(cardNumber.Substring(0, 3))) <= 649)) ||
                    cardNumber.Substring(0, 2) == "65")
                {
                    return CardType.DISCOVER;
                }
                else
                {
                    return CardType.NONE;
                }
            }
            catch (Exception)
            {
                TextBoxCardNumber.Style.Add(HtmlTextWriterStyle.BorderColor, "#FF0000");
                TextBoxCardNumber.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
                return CardType.NONE;
            }
            
        }

        protected void TextBoxCardNumber_TextChanged(object sender, EventArgs e)
        {
            CardType cardType = FindCardType(TextBoxCardNumber.Text);
            bool isOK = IsCreditCardNumberOKForLuhn();

            if (!isOK || cardType == CardType.NONE || !TextBoxCardNumber.Text.All(char.IsDigit))
            {
                TextBoxCardNumber.Style.Add(HtmlTextWriterStyle.BorderColor, "#FF0000");
                TextBoxCardNumber.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
                ImageBoxCardType.Visible = false;
                return;
            }
            else
            {
                TextBoxCardNumber.Style.Add(HtmlTextWriterStyle.BorderColor, "#00FF00");
                TextBoxCardNumber.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }

            //if(TextBoxExpiryDate.)

            switch (cardType)
            {
                case CardType.NONE:
                    ImageBoxCardType.Visible = true;
                    ImageBoxCardType.Src = "https://localhost:44312/img/visa.png";
                    break;
                case CardType.VISA:
                    ImageBoxCardType.Visible = true;
                    ImageBoxCardType.Src = "https://localhost:44312/img/visa.png";
                    break;
                case CardType.VISA_ELECTRON:
                    ImageBoxCardType.Visible = true;
                    ImageBoxCardType.Src = "https://localhost:44312/img/visa-electron.png";
                    break;
                case CardType.MASTERCARD:
                    ImageBoxCardType.Visible = true;
                    ImageBoxCardType.Src = "https://localhost:44312/img/mastercard.png";
                    break;
                case CardType.MAESTRO:
                    ImageBoxCardType.Visible = true;
                    ImageBoxCardType.Src = "https://localhost:44312/img/maestro.png";
                    break;
                case CardType.DISCOVER:
                    ImageBoxCardType.Visible = true;
                    ImageBoxCardType.Src = "https://localhost:44312/img/discover.png";
                    break;
                default:
                    ImageBoxCardType.Visible = false;
                    break;
            }
        }


        protected void TextBoxExpiryDate_TextChanged(object sender, EventArgs e)
        {
            DateTime expiryDate = DateTime.Parse(TextBoxExpiryDate.Text);
            if (expiryDate < DateTime.Now)
            {
                TextBoxExpiryDate.Style.Add(HtmlTextWriterStyle.BorderColor, "#FF0000");
                TextBoxExpiryDate.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }
            else
            {
                TextBoxExpiryDate.Style.Add(HtmlTextWriterStyle.BorderColor, "#00FF00");
                TextBoxExpiryDate.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }
        }

        protected void TextBoxCVV_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxCVV.Text == String.Empty || TextBoxCVV.Text.Length < 3 || TextBoxCVV.Text.Length > 3)
            {
                TextBoxCVV.Style.Add(HtmlTextWriterStyle.BorderColor, "#FF0000");
                TextBoxCVV.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }
            else
            {
                TextBoxCVV.Style.Add(HtmlTextWriterStyle.BorderColor, "#00FF00");
                TextBoxCVV.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }
        }

        protected void TextBoxNameOnCard_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxNameOnCard.Text.Any(char.IsDigit))
            {
                TextBoxNameOnCard.Style.Add(HtmlTextWriterStyle.BorderColor, "#FF0000");
                TextBoxNameOnCard.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }
            else
            {
                TextBoxNameOnCard.Style.Add(HtmlTextWriterStyle.BorderColor, "#00FF00");
                TextBoxNameOnCard.Style.Add(HtmlTextWriterStyle.BorderWidth, "1px");
            }
        }
    }
}