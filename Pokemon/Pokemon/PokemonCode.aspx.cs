using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pokemon
{
    public partial class PokemonCode : System.Web.UI.Page
    {
        public double result;
        protected void Page_Load(object sender, EventArgs e)
        {
            TotalPrice.Visible = false;
        }

        public void CalculateDiscount_Click(object sender, EventArgs e)
        {
            int  Pikachu_Actual =(Convert.ToInt16(PikachuQuantity.Text));
            int Squirtle_Actual = (Convert.ToInt16(SquirtleQuanity.Text));
            int Charmander_Actual = (Convert.ToInt16(CharmanderQuantity.Text));
            TotalPrice.Visible = true;
            TotalPrice.Text = total(Pikachu_Actual, Squirtle_Actual, Charmander_Actual).ToString();
          
        }
        public double total (int Pikachu, int Squirtle, int Charmander)
        {
           
            if (Pikachu != 0 && Charmander != 0 && Squirtle != 0)
            {

                if (Pikachu == Charmander && Pikachu == Squirtle)
                {



                    return  result =  (((Pikachu * 6) + (Charmander * 5) + (Squirtle * 5)) * (0.8));

                }
                else if (Pikachu != Charmander && Charmander == Squirtle)
                {



                    int diff = Pikachu - Charmander;

                    double totalWithDiscount = (((Pikachu - diff) * 6) + (Charmander * 5) + (Squirtle * 5)) * (0.8);

                    return result= ((diff * 6) + (totalWithDiscount));

                }
                else if (Pikachu == Squirtle && Charmander != Squirtle)
                {
                    int diff = Pikachu - Charmander;

                    double totalWithDiscount = (((Pikachu - diff) * 6) + (Charmander * 5) + (Squirtle * 5)) * (0.8);

                    TotalPrice.Text = ((diff * 6) + (totalWithDiscount)).ToString();
                    return result = (diff * 6) + (totalWithDiscount);
                }

            }
            else if (Pikachu != 0 && Charmander == 0 && Squirtle == 0)
            {



                return result = (Pikachu * 6);

            }
            else if (Pikachu == 0 && Charmander != 0 && Squirtle == 0)
            {



                return result = (Charmander * 5);

            }
            else if (Pikachu == 0 && Charmander == 0 && Squirtle != 0)
            {



                return result = (Squirtle * 5);

            }
            else if (Pikachu != 0 && Charmander == 0 && Squirtle != 0)
            {

                if (Pikachu == Squirtle)
                {



                    return result = ((Pikachu * 6) + (Squirtle * 5)) * (0.9);

                }
                else
                {



                    int diff = Pikachu - Squirtle;

                    double totalWithDiscount = (((Pikachu - diff) * 6) + (Squirtle * 5)) * (0.9);

                    return result = (diff * 6) + (totalWithDiscount);

                }

            }
            else if (Pikachu != 0 && Charmander != 0 && Squirtle == 0)
            {
                if (Pikachu == Charmander)
                {



                    return result = ((Pikachu * 6) + (Charmander * 5)) * (0.9);

                }
                else
                {
                    int diff = Pikachu - Charmander;

                    double totalWithDiscount = (((Pikachu - diff) * 6) + (Charmander * 5)) * (0.9);

                    return result= (diff * 6) + (totalWithDiscount);

                }
            }
            else if (Pikachu == 0 && Charmander != 0 && Squirtle != 0)
            {
                if (Charmander == Squirtle)
                {
                    return result= ((Squirtle * 5) + (Charmander * 5)) * (0.9);
                }
                else
                {
                    if (Charmander > Squirtle)
                    {
                        int diff = Charmander - Squirtle;

                        double totalWithDiscount = (((Charmander - diff) * 6) + (Squirtle * 5)) * (0.9);

                        return result= (diff * 6) + (totalWithDiscount);
                    }
                    else
                    {
                        int diff = Squirtle - Charmander;

                        double totalWithDiscount = (((Squirtle - diff) * 6) + (Charmander * 5)) * (0.9);

                        return result= (diff * 6) + (totalWithDiscount);
                    }
                }
              

            }
            TotalPrice.Text = result.ToString();
            return result;
        }
    }
}